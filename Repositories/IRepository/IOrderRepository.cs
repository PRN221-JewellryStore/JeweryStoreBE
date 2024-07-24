using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface IOrderRepository : IEFRepository<OrderEntity, OrderEntity>
    {
        Task<List<OrderEntity>> GetAllWithDetail(CancellationToken cancellationToken);
        Task<OrderEntity> GetOrderInCart(CancellationToken cancellationToken, string userid);
    }
}
