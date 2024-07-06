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
    //[ApiController]
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
        public async Task<ActionResult<CounterEntity>> GetById(int id)
        {
            return Ok(await _counterService.GetById(id));
        }
        /*  [HttpGet]
          public async Task<ActionResult<CategoryEntity>> GetAll() {
          return Ok (await _categoryService.GetAll());    
          }*/


        [AllowAnonymous]
        [HttpGet]
        [Route("Counter/getall")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<CounterEntity>>> GetAll()
        {
            var categories = await _counterService.GetAll();
            return Ok(categories);
        }
        [HttpPost]
        public async Task<ActionResult<CategoryDTO>> CreateCategory([FromForm] CounterDTO counter)
        {


            return Ok(await _counterService.Add(counter));

        }
        [HttpPatch]

        [Route("counter/Update")]

            public async Task<ActionResult> UpdateCounter([FromForm] CounterDTO counter, int id)
            {

                try
                { var getCounter = await _counterService.GetById(id);
                    if (getCounter == null)
                    {
                        return NotFound(new { Message = "Counter not found" });


                    }
                    else
                    {
                       await _counterService.Update(counter, id);
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
        [Route("counter/Delete")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteCounter(int id, string userId, CancellationToken cancellationToken = default)
        {
            var categoryEntity = await _counterService.GetById(id); // Ensure you have a method to get category by id
            var User = await _userService.GetUser(userId, cancellationToken);
            if (categoryEntity == null)
            {
                return NotFound(new { Message = "Counter not found" });
            }

            // Call the delete method
            await _counterService.Delete(categoryEntity, User);

            return Ok(new { Message = "Counter deleted successfully" });
        }

    }
}
