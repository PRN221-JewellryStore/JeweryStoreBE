using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
using BusinessObjecs.Models.Configured;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IService
{
    public interface ICategoryService
    {
        public Task<CategoryDTO> GetById(int id);
        public Task<List<CategoryDTO>> GetAll();
        public Task<CategoryDTO> Add(CategoryDTO CategoryEntity);
        public Task Update(CategoryDTO CategoryEntity, int Id);
        public Task Delete(int id, UserDTO user);

        public  Task<Decimal> GetRevenueByCategory(int id);

    }
}
