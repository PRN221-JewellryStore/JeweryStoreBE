using AutoMapper;
using BusinessObjecs.Models.Configured;
using Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.RepositoryImpl
{
    public class RoleRepository : RepositoryBase<RoleEntity, RoleEntity, JeweryStoreDBContext>, IRoleRepository
    {
        public RoleRepository(JeweryStoreDBContext dBContext, IMapper mapper) : base(dBContext, mapper)
        {
            
        }
    }
}
