using AutoMapper;
using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
using BusinessObjecs.Models.Configured;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.RepositoryImpl
{
    public class CategoryRepository : RepositoryBase<CategoryEntity, CategoryEntity, JeweryStoreDBContext>, ICategoryRepository
    {
        private readonly JeweryStoreDBContext _Context;
        private readonly IMapper _mapper;

        public CategoryRepository(JeweryStoreDBContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            _Context = dbContext;
            _mapper = mapper;

        }

    /*    public async CategoryDTO AddCategory(CategoryDTO category)
        {

      
        } */
        public async Task<List<CategoryEntity>> GetAll()
        {
            return await _Context.categoryEntities
                 .Where(c => c.DeleterID == null)
                 .ToListAsync();
        }
        /*      private readonly JeweryStoreDBContext _Context;
              private readonly ICategoryRepository _CategoryRepository;*/

        public async Task<List<CategoryEntity>> FindAsync(Expression<Func<CategoryEntity, bool>> expression)
        {
            return await _Context.Set<CategoryEntity>().Where(expression).ToListAsync();
        }
        public async Task<CategoryEntity> GetCategoryById(int id)
        {
            return await _Context.Set<CategoryEntity>().FindAsync(id);
        }
     
        public bool IsAdmin(UserEntity user)
        {
            var IsAdmin = _Context.userEntities
                .Include (p=> p.Role)
                .Any(p => p.ID == user.ID && p.Role.Name == "admin");
            if (IsAdmin != null) {
                return false;
            }else {
                return true;
            }
        }

        public  async Task DeleteCategoryById(CategoryEntity entity, String DeletedId)
        {
            var categoryDelete = await _Context.Set<CategoryEntity>().FindAsync(entity.ID);
            //check xem User co phair admin khong -> Neu la ADmin gang DeleteId = UserId
            if (categoryDelete != null)
            {
                categoryDelete.DeleterID = DeletedId; // Đánh dấu xóa bằng cách gán DeletedId
                _Context.Update(categoryDelete);
                await _Context.SaveChangesAsync();
            }
        }

       

       

        public Task UpdateCategoryById(CategoryEntity entity, int id)
        {
        /*    var ExistingCategory = _Context.categoryEntities
            _Context.Update(entity);
             _Context.SaveChangesAsync(); 
*/
            return Task.CompletedTask ;

        }

        public bool IsAdmin()
        {
            throw new NotImplementedException();
        }

      /*  public async Task<CategoryDTO> AddCategoryAsync(CategoryDTO categoryDto)
        {
         *//*   try
            {
              
                // Map CategoryDTO to CategoryEntity using AutoMapper
                var categoryEntity = _mapper.Map<CategoryEntity>(categoryDto);

                // Add the CategoryEntity to the context
                _Context.Set<CategoryEntity>().Add(categoryEntity);
                if (categoryEntity == null)
                {
                    throw new InvalidOperationException("Mapping resulted in a null CategoryEntity");
                }
                Console.WriteLine("Mapped CategoryEntity: " + categoryEntity);
                if (_Context == null)
                {
                    throw new InvalidOperationException("_Context is not initialized");
                }
                // Save changes asynchronously
                await _Context.SaveChangesAsync();

                // Map the saved CategoryEntity back to CategoryDTO
                var addedCategoryDto = _mapper.Map<CategoryDTO>(categoryEntity);

                return addedCategoryDto;
            }
            catch (DbUpdateException dbEx)
            {
                // Log detailed database update exception
                Console.WriteLine($"Database update exception: {dbEx.Message}");
                if (dbEx.InnerException != null)
                {
                    Console.WriteLine($"Inner exception: {dbEx.InnerException.Message}");
                }
                throw;
            }
            catch (Exception ex)
            {
                // Log general exception
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }*//*
        
            GetSet().Add((TPersistence)entity);

        }

        public async Task<CategoryDTO> AddCategoryAsync(CategoryDTO categoryDto)
        {
           

            GetSet().Add((CategoryDTO)categoryDto);

        }
        public virtual void Add(TDomain entity)
        {
        }*/
    }
}
