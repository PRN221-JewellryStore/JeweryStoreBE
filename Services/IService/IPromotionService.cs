using BusinessObjecs.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IService
{
    public interface IPromotionService
    {
        public Task<PromotionDTO> GetById(string id);
        public Task<List<PromotionDTO>> GetAll();
        public Task<PromotionDTO> Add(PromotionDTO promotionDTO);
        public Task<PromotionDTO> Update(PromotionDTO promotionDTO);
        public Task<PromotionDTO> Delete(string id);
    }
}
