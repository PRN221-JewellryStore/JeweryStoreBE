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

        public PromotionRepository(JeweryStoreDBContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
