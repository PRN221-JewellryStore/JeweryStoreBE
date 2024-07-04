using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
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
        Task<OrderEntity> GetById(string id, CancellationToken cancellationToken);
        Task<List<OrderEntity>> GetAll(CancellationToken cancellationToken);
        Task<OrderDTO> Add(OrderDTO OrderDTO, CancellationToken cancellationToken);
        Task<OrderDTO> Update(string id, OrderDTO OrderDTO, CancellationToken cancellationToken);
        Task<OrderDTO> Delete(string id, CancellationToken cancellationToken, ClaimsPrincipal claims);
    }
}
