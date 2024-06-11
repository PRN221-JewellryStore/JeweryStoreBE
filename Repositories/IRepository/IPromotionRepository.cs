using BusinessObjecs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface IPromotionRepository
    {
        IQueryable<PromotionEntity> Entities { get; }

        Task<List<PromotionEntity>> FindAsync(Expression<Func<PromotionEntity, bool>> expression);

        Task<PromotionEntity?> FindOneAsync(Expression<Func<PromotionEntity, bool>> expression, bool hasTrackings = true);

        Task<PromotionEntity?> GetByIdAsync(string id);

        Task<List<PromotionEntity>> GetAllAsync();

        Task AddAsync(PromotionEntity TEntity);

        Task UpdateAsync(PromotionEntity TEntity);

        Task DeleteAsync(PromotionEntity TEntity);
    }
}
