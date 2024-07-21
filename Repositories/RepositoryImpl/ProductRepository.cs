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

        public async Task<List<ProductEntity>> SearchbyCategory( CancellationToken cancellationToken)
        {
            return await _dbContext.productEntities.Include(o => o.Category).ToListAsync(cancellationToken);
        }

        public async Task<List<ProductEntity>> SearchByNameAsync(string name, CancellationToken cancellationToken)
        {
            var query = _dbContext.productEntities.AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(x => x.Name.ToLower().Contains(name.ToLower()));
            }

            return await query.ToListAsync(cancellationToken);
        }

    }
}
