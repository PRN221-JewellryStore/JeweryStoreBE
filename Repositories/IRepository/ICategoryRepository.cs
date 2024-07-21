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
      //  Task<List<CategoryEntity>> FindAsync(Expression<Func<CategoryEntity, bool>> expression);

        Task<List<CategoryEntity>> GetAll();

        Task <CategoryEntity> GetCategoryById(int id);

        Task DeleteCategoryById(int id, string DeletedId);
        Task UpdateCategoryById(CategoryEntity entity, int id);
        Task<IQueryable<CategoryEntity>> GetCategoriesWithProductsAndOrderDetailsAsync();


    //    Task<CategoryDTO> AddCategoryAsync(CategoryDTO categoryDto);

        //  public bool IsAdmin(UserEntity user);


    }
}
