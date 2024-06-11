using BusinessObjecs.DTOs;
using Repositories.IRepository;
using Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapster;
using BusinessObjecs.Models;

namespace Services.ServiceImpl
{
    public class PromotionService : IPromotionService
    {
        IPromotionRepository _promotionRepository;

        public PromotionService(IPromotionRepository promotionRepository) {
            _promotionRepository = promotionRepository;
        }

        public async Task<PromotionDTO> Add(PromotionDTO promotionDTO)
        {
            await _promotionRepository.AddAsync(promotionDTO.Adapt<PromotionEntity>());
            return promotionDTO;
        }

        public async Task<PromotionDTO> Delete(string id)
        {
            var promotion = await _promotionRepository.GetByIdAsync(id);
            if (promotion is null)
            {
                throw new Exception("Promotion not found");
            }
            await _promotionRepository.DeleteAsync(promotion);
            return promotion.Adapt<PromotionDTO>();
        }

        public async Task<List<PromotionDTO>> GetAll()
        {

            return (await _promotionRepository.GetAllAsync()).Adapt<List<PromotionDTO>>();
        }

        public async Task<PromotionDTO> GetById(string id)
        {
            return (await _promotionRepository.GetByIdAsync(id)).Adapt<PromotionDTO>();
        }

        public async Task<PromotionDTO> Update(PromotionDTO promotionDTO)
        {
            await _promotionRepository.UpdateAsync(promotionDTO.Adapt<PromotionEntity>());
            return promotionDTO;
        }
    }
}
