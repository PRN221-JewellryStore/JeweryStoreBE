using AutoMapper;
using BusinessObjecs.Models;
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

        public OrderRepository(JeweryStoreDBContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
