using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
using Mapster;
using Repositories.Common.Exceptions;
using Repositories.IRepository;
using Services.IService;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServiceImpl
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _ProductRepository;

        public ProductService(IProductRepository ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }

        public async Task<ProductDTO> Add(ProductDTO ProductDTO, CancellationToken cancellationToken)
        {
            _ProductRepository.Add(ProductDTO.Adapt<ProductEntity>());
            if (await _ProductRepository.UnitOfWork.SaveChangesAsync(cancellationToken) != 0)
            {
                return ProductDTO;
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
            throw new Exception("Something went wrong! Delete action unsuccesful");
        }

        public async Task<List<ProductEntity>> GetAll(CancellationToken cancellationToken)
        {
            var result = await _ProductRepository.FindAllAsync(cancellationToken);
            return result;
        }

        public async Task<ProductEntity> GetById(string id, CancellationToken cancellationToken)
        {
            var result = await _ProductRepository.FindAsync(p => p.ID.Equals(id));
            if (result is null)
            {
                throw new NotFoundException("Product not existed");
            }
            return result;
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
            throw new Exception("Something went wrong! Delete action unsuccesful");
        }
    }
}
