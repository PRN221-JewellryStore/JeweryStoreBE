using AutoMapper;
using BusinessObjecs.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.RepositoryImpl
{
    public class OrderRepository : RepositoryBase<OrderEntity, OrderEntity, JeweryStoreDBContext>, IOrderRepository
    {
        private readonly JeweryStoreDBContext _dbContext;

        public OrderRepository(JeweryStoreDBContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            _dbContext = dbContext;
        }
        public async Task<List<OrderEntity>> GetAllWithDetail(CancellationToken cancellationToken)
        {
            var order = await _dbContext.orderEntities
                .AsNoTracking()
                .AsSplitQuery()
                .Include(o => o.Promotion)
                .Include(o => o.User)
                .Include(o => o.OrderDetails)
                    .ThenInclude(or => or.Product)
                .ToListAsync(cancellationToken);
            return order;
        }

        public async Task<OrderEntity> GetOrderInCart(CancellationToken cancellationToken , string userid)
        {
            var order = await _dbContext.orderEntities
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Status == "Pending" && p.UserID == userid);
               return order;            
        }
    }
}
