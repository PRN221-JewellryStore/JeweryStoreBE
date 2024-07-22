using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
using BusinessObjecs.ResponseModels;
using BusinessObjecs.ResponseModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Services.IService
{
    public interface IOrderDetailService : IServices<OrderDetailEntity>
    {
        Task<GetOrderDetailResponse> GetById(string id, CancellationToken cancellationToken);
        Task<List<GetOrderDetailResponse>> GetAll(CancellationToken cancellationToken);
        Task<GetOrderResponse> Add(OrderDetailDTO OrderDetailDTO, CancellationToken cancellationToken, ClaimsPrincipal claims);
        Task<GetOrderResponse> Update(string id, OrderDetailDTO OrderDetailDTO, CancellationToken cancellationToken, ClaimsPrincipal claims);
        Task<OrderDetail> Delete(string id, CancellationToken cancellationToken, ClaimsPrincipal claims);
    }
}
