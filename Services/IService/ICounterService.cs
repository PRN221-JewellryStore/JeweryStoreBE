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
        public Task<CounterDTO> GetById(int id);
        public Task<List<CounterEntity>> GetAll();
        public Task<CounterDTO> Add(CounterDTO CategoryEntity);
        public Task Update(CounterDTO CategoryEntity, int id);
        public Task Delete(CounterDTO CategoryEntity, UserDTO user);
    }
}
