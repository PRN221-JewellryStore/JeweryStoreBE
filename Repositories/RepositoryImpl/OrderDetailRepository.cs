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
    public class OrderDetailRepository : RepositoryBase<OrderDetailEntity, OrderDetailEntity, JeweryStoreDBContext>, IOrderDetailRepository
    {
        private readonly JeweryStoreDBContext _dbContext;

        public OrderDetailRepository(JeweryStoreDBContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            _dbContext = dbContext;
        }
        public async Task<List<OrderDetailEntity>> GetAllWithDetail(CancellationToken cancellationToken)
        {
            var orderDetail = await _dbContext.orderDetailEntities
                .AsNoTracking()
                .AsSplitQuery()
                .Include(o => o.Order)
                .Include(o => o.Product)
                .ToListAsync(cancellationToken);
            return orderDetail;
        }
    }
}
