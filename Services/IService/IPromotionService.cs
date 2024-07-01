using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IService
{
    public interface IPromotionService : IServices<PromotionEntity>
    {
        Task<PromotionEntity> GetById(string id, CancellationToken cancellationToken);
        Task<List<PromotionEntity>> GetAll(CancellationToken cancellationToken);
        Task<PromotionDTO> Add(PromotionDTO promotionDTO, CancellationToken cancellationToken);
        Task<PromotionDTO> Update(string id, PromotionDTO promotionDTO, CancellationToken cancellationToken);
        Task<PromotionDTO> Delete(string id, CancellationToken cancellationToken);
    }
}
