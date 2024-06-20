using AutoMapper;
using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
using BusinessObjecs.Models.Configured;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;
using Repositories.RepositoryImpl;
using Services.IService;
using System;
using System.Collections.Generic;
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

        public async  Task Delete(CategoryEntity CategoryEntity, UserEntity user)
        {
            /*   if (!_categoryRepository.IsAdmin(user)) {
                   throw new UnauthorizedAccessException("User is not an admin.");
               }*/
            if (CategoryEntity == null)
            {
                throw new ArgumentNullException(nameof(CategoryEntity), "Category entity is null");
            }

            // Check if userId is valid (optional but recommended)
            if (user.ID ==null)
            {
                throw new ArgumentException("Invalid user ID", nameof(user.ID));
            }
            await _categoryRepository.DeleteCategoryById(CategoryEntity, user.ID);
        }

        public async Task<List<CategoryEntity>> GetAll()
        {
            return await _categoryRepository.GetAll();
             
        }

        public async Task<CategoryEntity> GetById(int id)
        {
            return await _categoryRepository.GetCategoryById(id);
        }

        public async Task Update(CategoryEntity CategoryEntity)
        {
             await _categoryRepository.UpdateCategoryById(CategoryEntity);
        }
    }
}
