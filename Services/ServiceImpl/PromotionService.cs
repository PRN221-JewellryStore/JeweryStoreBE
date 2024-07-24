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
using Repositories.Common.Exceptions;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Repositories.RepositoryImpl;
using BusinessObjecs.ResponseModels;

namespace Services.ServiceImpl
{
    public class PromotionService : IPromotionService
    {
        private readonly IPromotionRepository _promotionRepository;

        public PromotionService(IPromotionRepository promotionRepository) {
            _promotionRepository = promotionRepository;
        }

        public async Task<PromotionDTO> Add(PromotionDTO promotionDTO, CancellationToken cancellationToken)
        {
            var promotion = promotionDTO.Adapt<PromotionEntity>();
            promotion.Status = "Active";
            _promotionRepository.Add(promotion);
            if (await _promotionRepository.UnitOfWork.SaveChangesAsync(cancellationToken) != 0)
            {
                return promotionDTO;
            }
            throw new Exception("Something went wrong! Add action unsuccesful");
        }

        public async Task<PromotionDTO> Delete(string id, CancellationToken cancellationToken, ClaimsPrincipal claims)
        {
            var promotion = await _promotionRepository.FindAsync(p => p.ID.Equals(id));
            if (promotion is null)
            {
                throw new NotFoundException("Promotion not existed!");
            }
            promotion.DeleterID = claims.FindFirst(JwtRegisteredClaimNames.Sub)?.Value;
            promotion.DeletedAt = DateTime.Now;

            if (await _promotionRepository.UnitOfWork.SaveChangesAsync(cancellationToken) != 0)
            {
                return promotion.Adapt<PromotionDTO>();
            }
            throw new Exception("Something went wrong! Delete action unsuccesful");
        }

        public async Task<List<GetPromotionResponse>> GetAll(CancellationToken cancellationToken)
        {
            var result = await _promotionRepository.GetAllWithDetail(cancellationToken);
            return result.Adapt<List<GetPromotionResponse>>();
        }

        public async Task<GetPromotionResponse> GetById(string id, CancellationToken cancellationToken)
        {
            var result = (await _promotionRepository.GetAllWithDetail(cancellationToken)).FirstOrDefault(p => p.ID.Equals(id));
            if (result is null)
            {
                throw new NotFoundException("Promotion not existed");
            }
            return result.Adapt<GetPromotionResponse>();
        }

        public async Task<PromotionDTO> Update(string id, PromotionDTO promotionDTO, CancellationToken cancellationToken)
        {
            var promotion = await _promotionRepository.FindAsync(p => p.ID.Equals(id));
            if (promotion is null)
            {
                throw new NotFoundException("Promotion not found!");
            }
            try
            {
                promotion.Description = promotionDTO.Description;
                promotion.ConditionsOfUse = promotionDTO.ConditionsOfUse;
                promotion.ReducedPercent = promotionDTO.ReducedPercent;
                promotion.MaximumReduce = promotionDTO.MaximumReduce;
                promotion.ExpiresTime = promotionDTO.ExpiresTime;
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            
            if (await _promotionRepository.UnitOfWork.SaveChangesAsync(cancellationToken) != 0)
            {
                return promotionDTO;
            }
            throw new Exception("Something went wrong! Delete action unsuccesful");
        }
    }
}
