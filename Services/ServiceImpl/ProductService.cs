using AutoMapper;
using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
using BusinessObjecs.ResponseModels;
using BusinessObjecs.ResponseModels.Models;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Repositories.Common.Exceptions;
using Repositories.IRepository;
using Repositories.RepositoryImpl;
using Services.IService;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServiceImpl
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _ProductRepository;
        private readonly IMapper _mapper;


        public ProductService(IProductRepository ProductRepository)
        {
            _ProductRepository = ProductRepository;
            
        }

        public async Task<GetProductResponse> Add(ProductDTO ProductDTO, CancellationToken cancellationToken)
        {
            var product = ProductDTO.Adapt<ProductEntity>();
            _ProductRepository.Add(product);
            if (await _ProductRepository.UnitOfWork.SaveChangesAsync(cancellationToken) != 0)
            {
                return product.Adapt<GetProductResponse>();
            }
            throw new Exception("Something went wrong! Add action unsuccesful");
        }

        public async Task<ProductDTO> Delete(string id, CancellationToken cancellationToken, ClaimsPrincipal claims)
        {

            var Product = await _ProductRepository.FindAsync(p => p.ID.Equals(id));
            if (Product is null)
            {
                throw new NotFoundException("Product not existed!");
            }

            Product.DeleterID = claims.FindFirst(JwtRegisteredClaimNames.Sub)?.Value;
            Product.DeletedAt = DateTime.Now;

            if (await _ProductRepository.UnitOfWork.SaveChangesAsync(cancellationToken) != 0)
            {
                return Product.Adapt<ProductDTO>();
            }
            return Product.Adapt<ProductDTO>();
        }

        public async Task<List<GetProductResponse>> SearchByName(string name, CancellationToken cancellationToken)
        {
            var productEntities = await _ProductRepository.SearchByNameAsync(name, cancellationToken);

            // Assuming you have AutoMapper configured for ProductEntity to GetProductResponse

            return productEntities.Adapt<List<GetProductResponse>>();
        }

        public async Task<List<GetProductResponse>> GetAll(CancellationToken cancellationToken)
        {
            var result = await _ProductRepository.GetAllWithDetail(cancellationToken);
            return result.Adapt<List<GetProductResponse>>();
        }

        public async Task<GetProductResponse> GetById(string id, CancellationToken cancellationToken)
        {
            var result = (await _ProductRepository.GetAllWithDetail(cancellationToken)).FirstOrDefault(p => p.ID.Equals(id));
            if (result is null)
            {
                throw new NotFoundException("Product not existed");
            }
            return result.Adapt<GetProductResponse>();
        }

        public async Task<ProductDTO> Update(string id, ProductDTO ProductDTO, CancellationToken cancellationToken)
        {
            var Product = await _ProductRepository.FindAsync(p => p.ID.Equals(id));
            if (Product is null)
            {
                throw new NotFoundException("Product not found!");
            }
            try
            {
                Product.Cost = ProductDTO.Cost;
                Product.Weight = ProductDTO.Weight;
                Product.Quantity = ProductDTO.Quantity;
                Product.Description = ProductDTO.Description;
                Product.CategoryID = ProductDTO.CategoryID;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            if (await _ProductRepository.UnitOfWork.SaveChangesAsync(cancellationToken) != 0)
            {
                return ProductDTO;
            }
            return ProductDTO;
        }

        public async Task<List<GetProductResponse>> SearchbyCategory(int id, CancellationToken cancellationToken)
        {
            var query = await  _ProductRepository.SearchbyCategory(cancellationToken);
            var filteredQuery = query.Where(p => p.CategoryID == id);
          //  var productEntities = await filteredQuery.ToList(cancellationToken);
            return filteredQuery.Adapt<List<GetProductResponse>>();
        }
    }
}
