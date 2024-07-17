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
    public interface IPromotionRepository : IEFRepository<PromotionEntity, PromotionEntity>
    {
        Task<List<PromotionEntity>> GetAllWithDetail(CancellationToken cancellationToken);
    }
}
