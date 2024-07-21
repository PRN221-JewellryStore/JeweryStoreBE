using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
using BusinessObjecs.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Services.IService
{
    public interface IProductService : IServices<ProductEntity>
    {
        Task<GetProductResponse> GetById(string id, CancellationToken cancellationToken);
        Task<List<GetProductResponse>> GetAll(CancellationToken cancellationToken);
        Task<ProductDTO> Add(ProductDTO productDTO, CancellationToken cancellationToken);
        Task<ProductDTO> Update(string id, ProductDTO productDTO, CancellationToken cancellationToken);
        Task<ProductDTO> Delete(string id, CancellationToken cancellationToken, ClaimsPrincipal claims);

        Task<List<GetProductResponse>> SearchByName(string name, CancellationToken cancellationToken);

    }
}
