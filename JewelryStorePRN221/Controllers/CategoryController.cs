using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
using BusinessObjecs.Models.Configured;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repositories.IRepository;
using Repositories.RepositoryImpl;
using Services.IService;
using Services.ServiceImpl;
using System.Net.Mime;

namespace JewelryStorePRN221.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryService _categoryService;
        IUserServices _userService;

        public CategoryController(ICategoryService categoryService ,IUserServices userServices, IUserRepository userRepo)
        {
            _userService = userServices;
            _categoryService = categoryService;
        }
        [AllowAnonymous]
        [HttpGet("{id}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CategoryEntity>> GetById(int id, CancellationToken cancellationToken = default )
        {
            return Ok(await _categoryService.GetById(id, cancellationToken));
        }
        /*  [HttpGet]
          public async Task<ActionResult<CategoryEntity>> GetAll() {
          return Ok (await _categoryService.GetAll());    
          }*/


        [HttpGet]
        [Route("getall")]
        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<CategoryEntity>>> GetAll(CancellationToken cancellationToken = default)
        {
            var categories = await _categoryService.GetAll(cancellationToken);
            return Ok(categories);
        }
        [HttpPost]
        [Route("Create")]
        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CategoryDTO >> CreateCategory([FromForm] CategoryDTO category, CancellationToken cancellationToken = default) {

          
            return Ok(await _categoryService.Add(category, cancellationToken));

        }
        [HttpPatch]
        [Route("Update")]
        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> UpdateCategory([FromForm] CategoryDTO category, int id, CancellationToken cancellationToken = default) {
            try
            {
                var updatedCategory =  _categoryService.Update(category,  id, cancellationToken);
                return Ok(updatedCategory);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating the category: " + ex.Message);
            }
        }
        [HttpDelete]
        [AllowAnonymous]
        [Route("Delete")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteCategory(int id,  string userId, CancellationToken cancellationToken = default)
        {
            var categoryEntity = await _categoryService.GetById(id, cancellationToken); // Ensure you have a method to get category by id
            var User = await _userService.GetUser(userId, cancellationToken);
            if (categoryEntity == null)
            {
                return NotFound(new { Message = "Category not found" });
            }

            // Call the delete method
            await _categoryService.Delete(categoryEntity,User, cancellationToken);

            return Ok(new { Message = "Category deleted successfully" });
        }

    }
}
