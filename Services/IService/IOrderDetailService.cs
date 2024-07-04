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
    public interface IOrderDetailService : IServices<OrderDetailEntity>
    {
        Task<OrderDetailEntity> GetById(string id, CancellationToken cancellationToken);
        Task<List<OrderDetailEntity>> GetAll(CancellationToken cancellationToken);
        Task<OrderDetailDTO> Add(OrderDetailDTO OrderDetailDTO, CancellationToken cancellationToken);
        Task<OrderDetailDTO> Update(string id, OrderDetailDTO OrderDetailDTO, CancellationToken cancellationToken);
        Task<OrderDetailDTO> Delete(string id, CancellationToken cancellationToken, ClaimsPrincipal claims);
    }
}
