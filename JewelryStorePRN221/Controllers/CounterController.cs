using BusinessObjecs.DTOs;
using BusinessObjecs.Models.Configured;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.IRepository;
using Services.IService;
using System.Net.Mime;

namespace JewelryStorePRN221.Controllers
{
    [Route("api/[controller]")]
    public class CounterController : ControllerBase
    {
        ICounterService _counterService;
        IUserServices _userService;

        public CounterController(ICounterService CounterService, IUserServices userServices)
        {
            _userService = userServices;
            _counterService = CounterService;
        }
        [HttpGet("Counter/{id}")]
        public async Task<ActionResult<CounterDTOResponse>> GetById(int id)
        {
            var counterDto = await _counterService.GetById(id);

            if (counterDto == null)
            {
                return NotFound(); // Return 404 if counter with the given id is not found
            }

            return Ok(counterDto); // Return 200 with the counterDto if found
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
        public async Task<ActionResult<IEnumerable<CounterDTOResponse>>> GetAll()
        {
            var categories = await _counterService.GetAll();
            return Ok(categories);
        }

        [HttpPost]
        [Route("counter/Create")]
        public async Task<ActionResult<CategoryDTO>> CreateCategory([FromForm] CounterDTO counter)
        {


            return Ok(await _counterService.Add(counter));


        }
        [HttpPatch("Update/{id}")]

      //  [Route("counter/Update")]

            public async Task<ActionResult> UpdateCounter(int id, [FromForm] CounterDTO counter)
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
        [HttpDelete("Delete/{id}")]
        [AllowAnonymous]
      //  [Route("counter/Delete")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteCounter(int id, string userId, CancellationToken cancellationToken = default)
        {
            var counterDto = await _counterService.GetById(id); // Ensure you have a method to get category by id
            var User = await _userService.GetUser(userId, cancellationToken);
            if (User.RoleID != 1)
            {
                return NotFound(new { Message = "You are not have permission" });

            }
            if (counterDto == null)
            {
                return NotFound(new { Message = "Counter not found or already Deleted" });
            }

            // Call the delete method
            await _counterService.Delete(id, User);

            return Ok(new { Message = "Counter deleted successfully" });
        }

    }
}
