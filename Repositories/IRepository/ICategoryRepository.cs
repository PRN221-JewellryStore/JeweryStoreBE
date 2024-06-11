using BusinessObjecs.Models.Configured;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface ICategoryRepository
    {
        Task<List<CategoryEntity>> GetAll();

        Task <CategoryEntity> GetCategoryById();

        void DeleteCategoryById(CategoryEntity entity);
        void UpdateCategoryById(CategoryEntity entity);

        Task AddCategory (CategoryEntity category);  


    }
}
