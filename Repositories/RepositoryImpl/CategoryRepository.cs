using BusinessObjecs.Models.Configured;
using DAOs;
using Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.RepositoryImpl
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly JeweryStoreDBContext _Context;
        private readonly ICategoryRepository _CategoryRepository;

        public Task AddCategory(CategoryEntity category)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategoryById(CategoryEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryEntity> GetCategoryById()
        {
            throw new NotImplementedException();
        }

        public void UpdateCategoryById(CategoryEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
