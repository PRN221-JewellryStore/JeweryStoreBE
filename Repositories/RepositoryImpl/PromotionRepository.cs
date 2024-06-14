using BusinessObjecs.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;
using System.Linq.Expressions;

namespace Repositories.RepositoryImpl
{
    public class PromotionRepository : IPromotionRepository
    {

        private readonly JeweryStoreDBContext _context;

        public PromotionRepository(JeweryStoreDBContext context)
        {
            _context = context;
        }

        public IQueryable<PromotionEntity> Entities => _context.Set<PromotionEntity>();

        public Task AddAsync(PromotionEntity promotionEntity)
        {
            _context.Add(promotionEntity);
            return Task.CompletedTask;
        }

        public Task DeleteAsync(PromotionEntity promotionEntity)
        {
            _context.Remove(promotionEntity);
            return Task.CompletedTask;
        }

        public async Task<List<PromotionEntity>> FindAsync(Expression<Func<PromotionEntity, bool>> expression)
        {
            return await _context.Set<PromotionEntity>().Where(expression).ToListAsync();
        }

        public async Task<PromotionEntity?> FindOneAsync(Expression<Func<PromotionEntity, bool>> expression, bool hasTrackings = true)
        {
            return hasTrackings ? await _context.Set<PromotionEntity>().FirstOrDefaultAsync(expression)
                                : await _context.Set<PromotionEntity>().AsNoTracking().FirstOrDefaultAsync(expression);
        }

        public async Task<List<PromotionEntity>> GetAllAsync()
        {
            return await _context.Set<PromotionEntity>().ToListAsync();
        }

        public async Task<PromotionEntity?> GetByIdAsync(string id)
        {
            return await _context.Set<PromotionEntity>().FindAsync(id);
        }

        public Task UpdateAsync(PromotionEntity promotionEntity)
        {
            _context.Set<PromotionEntity>().Update(promotionEntity);
            return Task.CompletedTask;
        }
    }
}
