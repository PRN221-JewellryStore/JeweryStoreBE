using BusinessObjecs.DTOs;
using BusinessObjecs.Models.Configured;
using BusinessObjecs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IService
{
    public interface ICounterService
    {
        public Task<CounterEntity> GetById(int id, CancellationToken cancellationToken);
        public Task<List<CounterEntity>> GetAll(CancellationToken cancellationToken);
        public Task<CounterDTO> Add(CounterDTO CategoryEntity, CancellationToken cancellationToken);
        public Task Update(CounterDTO CategoryEntity, int id, CancellationToken cancellationToken);
        public Task Delete(CounterEntity CategoryEntity, UserDTO user, CancellationToken cancellationToken);
    }
}
