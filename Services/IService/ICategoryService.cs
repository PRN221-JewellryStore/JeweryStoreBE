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
        public Task<CategoryEntity> GetById(int id);
        public Task<List<CategoryEntity>> GetAll();
        public Task<CategoryDTO> Add(CategoryDTO CategoryEntity);
        public Task Update(CategoryEntity CategoryEntity);
        public Task Delete(CategoryEntity CategoryEntity, UserEntity user);
    }
}
