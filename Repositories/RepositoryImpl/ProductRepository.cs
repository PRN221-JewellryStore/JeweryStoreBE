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
    public class ProductRepository : RepositoryBase<ProductEntity, ProductEntity, JeweryStoreDBContext>, IProductRepository
    {

        public ProductRepository(JeweryStoreDBContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
