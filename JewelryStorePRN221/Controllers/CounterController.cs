using BusinessObjecs.DTOs;
using BusinessObjecs.Models.Configured;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.IRepository;
using Services.IService;
using System.Net.Mime;

namespace JewelryStorePRN221.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CounterController : ControllerBase
    {
        ICounterService _counterService;
        IUserServices _userService;

        public CounterController(ICounterService CounterService, IUserServices userServices)
        {
            _userService = userServices;
            _counterService = CounterService;
        }
        [HttpGet("{id}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CounterEntity>> GetById(int id, CancellationToken cancellationToken = default)
        {
            return Ok(await _counterService.GetById(id, cancellationToken));
        }
        /*  [HttpGet]
          public async Task<ActionResult<CategoryEntity>> GetAll() {
          return Ok (await _categoryService.GetAll());    
          }*/


        [AllowAnonymous]
        [HttpGet]
        [Route("getall")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<CounterEntity>>> GetAll(CancellationToken cancellationToken)
        {
            var categories = await _counterService.GetAll(cancellationToken);
            return Ok(categories);
        }
        [HttpPost]
        [AllowAnonymous]
        [Route("Create")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CategoryDTO>> CreateCategory([FromForm] CounterDTO counter, CancellationToken cancellationToken)
        {


            return Ok(await _counterService.Add(counter, cancellationToken));

        }
        [HttpPatch]

        [Route("Update")]
        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> UpdateCounter([FromForm] CounterDTO counter, int id, CancellationToken cancellationToken)
            {

                try
                { var getCounter = await _counterService.GetById(id, cancellationToken);
                    if (getCounter == null)
                    {
                        return NotFound(new { Message = "Counter not found" });


                    }
                    else
                    {
                       await _counterService.Update(counter, id, cancellationToken);
                        return Ok("Update success");
                    }
                }
                catch (Exception ex)
                {
                    return StatusCode(500, "An error occurred while updating the Counter: " + ex.Message);
                }
        }
        [HttpDelete]
        [AllowAnonymous]
        [Route("Delete")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteCounter(int id, string userId, CancellationToken cancellationToken = default)
        {
            var categoryEntity = await _counterService.GetById(id, cancellationToken); // Ensure you have a method to get category by id
            var User = await _userService.GetUser(userId, cancellationToken);
            if (categoryEntity == null)
            {
                return NotFound(new { Message = "Counter not found" });
            }

            // Call the delete method
            await _counterService.Delete(categoryEntity, User,cancellationToken);

            return Ok(new { Message = "Counter deleted successfully" });
        }

    }
}
