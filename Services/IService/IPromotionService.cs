﻿using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
using BusinessObjecs.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Services.IService
{
    public interface IPromotionService : IServices<PromotionEntity>
    {
        Task<GetPromotionResponse> GetById(string id, CancellationToken cancellationToken);
        Task<List<GetPromotionResponse>> GetAll(CancellationToken cancellationToken);
        Task<PromotionDTO> Add(PromotionDTO promotionDTO, CancellationToken cancellationToken);
        Task<PromotionDTO> Update(string id, PromotionDTO promotionDTO, CancellationToken cancellationToken);
        Task<PromotionDTO> Delete(string id, CancellationToken cancellationToken, ClaimsPrincipal claims);
    }
}
