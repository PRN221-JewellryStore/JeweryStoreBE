using AutoMapper;
using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
using BusinessObjecs.Models.Configured;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Repositories.Common.Exceptions;
using Repositories.IRepository;
using Repositories.RepositoryImpl;
using Services.IService;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServiceImpl
{
    public class CategoryService : ICategoryService
    {
        // private readonly UserRepository _userRepository;
        ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService( ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CategoryDTO> Add(CategoryDTO categoryDto)
        {
            /*    _categoryRepository.AddCategoryAsync(CategoryEntity);
               return CategoryEntity;*/


                // Map CategoryDTO to CategoryEntity using AutoMapper
                var categoryEntity = _mapper.Map<CategoryEntity>(categoryDto);
            // Add the CategoryEntity to the repository
            _categoryRepository.Add(categoryEntity);

                // Save changes asynchronously
                await _categoryRepository.UnitOfWork.SaveChangesAsync();

                // Map the saved CategoryEntity back to CategoryDTO
                var addedCategoryDto = _mapper.Map<CategoryDTO>(categoryEntity);

                return addedCategoryDto;

    }

        public async  Task Delete(CategoryDTO CategoryEntity, UserDTO user)
        {
            /*   if (!_categoryRepository.IsAdmin(user)) {
                   throw new UnauthorizedAccessException("User is not an admin.");
               }*/

            var categoryEntity = CategoryEntity.Adapt<CategoryEntity>();
            //var getCategory = await _categoryRepository.FindAsync(x => x.ID == categoryEntity.ID && x.DeleterID == null);
            if (CategoryEntity == null)
            {
                return;
            }

            // Check if userId is valid (optional but recommended)
          
            await _categoryRepository.DeleteCategoryById(categoryEntity, user.ID);
        }
        /*  
         var CounterEntity = counter.Adapt<CounterEntity>();
            var getCounter = await _counterRepository.FindAsync(x => x.ID == CounterEntity.ID && x.DeleterID == null);

            if (getCounter == null) {
                Console.WriteLine(" was not found or already deleted.");
                return;
            }
            else
            {
                getCounter.DeleterID = user.ID;
                getCounter.DeletedAt= DateTime.Now;
                _counterRepository.Update(getCounter);
                _counterRepository.UnitOfWork.SaveChangesAsync().Wait();
                await Task.CompletedTask;

            }*/
        public async Task<List<CategoryEntity>> GetAll()
        {
            return await _categoryRepository.GetAll();
             
        }

        public async Task<CategoryDTO> GetById(int id)
        {
            //
            var categoryEntity =  await _categoryRepository.GetCategoryById(id);
            return  categoryEntity.Adapt<CategoryDTO>();   
        }

        public async Task Update(CategoryDTO Categorydto, int id)
        {
            var existingCounterEntity = await _categoryRepository.GetCategoryById(id);
            if (existingCounterEntity == null)
            {
                throw new NotFoundException($"Category with ID {id} not found");
            }

            _mapper.Map(Categorydto, existingCounterEntity);
            _categoryRepository.Update(existingCounterEntity);
            await _categoryRepository.UnitOfWork.SaveChangesAsync();
        }
    }
}
