using AutoMapper;
using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;
using System.Linq.Expressions;

namespace Repositories.RepositoryImpl
{
    public class PromotionRepository : RepositoryBase<PromotionEntity, PromotionEntity, JeweryStoreDBContext>, IPromotionRepository
    {
        private readonly JeweryStoreDBContext _dbContext;

        public PromotionRepository(JeweryStoreDBContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            _dbContext = dbContext;
        }
        public async Task<List<PromotionEntity>> GetAllWithDetail(CancellationToken cancellationToken)
        {
            var promotion = await _dbContext.promotionEntities
                .AsNoTracking()
                .AsSplitQuery()
                .Include(o => o.Orders)
                .Include(o => o.User)
                .ToListAsync(cancellationToken);
            return promotion;
        }
    }
}
