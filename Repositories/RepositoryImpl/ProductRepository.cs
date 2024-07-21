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
    public class ProductRepository : RepositoryBase<ProductEntity, ProductEntity, JeweryStoreDBContext>, IProductRepository
    {
        private readonly JeweryStoreDBContext _dbContext;

        public ProductRepository(JeweryStoreDBContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            _dbContext = dbContext;
        }
        public async Task<List<ProductEntity>> GetAllWithDetail(CancellationToken cancellationToken)
        {
            var product = await _dbContext.productEntities
                .AsNoTracking()
                .AsSplitQuery()
                .Include(o => o.Category)
                .Include(o => o.OrderDetails)
                .ToListAsync(cancellationToken);
            return product;
        }

        public Task<List<ProductEntity>> Searchbyname(string name, CancellationToken cancellationToken)

        {
            var query = _dbContext.productEntities.AsQueryable();


        }
    }
}
