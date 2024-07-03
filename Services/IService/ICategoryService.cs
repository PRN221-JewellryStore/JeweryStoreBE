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
        public Task<CategoryEntity> GetById(int id, CancellationToken cancellationToken);
        public Task<List<CategoryEntity>> GetAll(CancellationToken cancellationToken);
        public Task<CategoryDTO> Add(CategoryDTO CategoryEntity, CancellationToken cancellationToken);
        public Task Update(CategoryDTO CategoryEntity, int Id, CancellationToken cancellationToken);
        public Task Delete(CategoryEntity CategoryEntity, UserDTO user, CancellationToken cancellationToken);
    }
}
