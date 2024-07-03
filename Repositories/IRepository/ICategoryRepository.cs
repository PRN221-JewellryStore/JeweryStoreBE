using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
using BusinessObjecs.Models.Configured;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface ICategoryRepository : IEFRepository<CategoryEntity, CategoryEntity>
    {
        Task<List<CategoryEntity>> FindAsync(Expression<Func<CategoryEntity, bool>> expression);

        Task<List<CategoryEntity>> GetAll(CancellationToken cancellationToken);

        Task <CategoryEntity> GetCategoryById(int id,CancellationToken cancellationToken);

        Task DeleteCategoryById(CategoryEntity entity, string DeletedId,CancellationToken cancellationToken);
        Task UpdateCategoryById(CategoryEntity entity, int id);

    //    Task<CategoryDTO> AddCategoryAsync(CategoryDTO categoryDto);

        public bool IsAdmin(UserEntity user);


    }
}
