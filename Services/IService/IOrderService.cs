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
    public interface IOrderService : IServices<OrderEntity>
    {
        Task<GetOrderResponse> GetById(string id, CancellationToken cancellationToken);
        Task<List<GetOrderResponse>> GetAll(CancellationToken cancellationToken);
        Task<List<GetOrderResponse>> Add(OrderDTO OrderDTO, CancellationToken cancellationToken, ClaimsPrincipal claims);
        Task<Order> Update(string id, OrderDTO OrderDTO, CancellationToken cancellationToken, ClaimsPrincipal claims);
        Task<Order> Delete(string id, CancellationToken cancellationToken, ClaimsPrincipal claims);
        Task<List<GetOrderResponse>> GetByUserId(string userId, CancellationToken cancellationToken);
        Task<Decimal?> getTotalRevenue(CancellationToken cancellationToken);

    }
}
