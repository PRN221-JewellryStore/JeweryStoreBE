using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
using BusinessObjecs.Models.Configured;
using Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface ICounterRepository : IEFRepository<CounterEntity, CounterEntity>
    {
      //  Task DeleteCategoryById(CategoryEntity entity, string DeletedId);

    }
}
