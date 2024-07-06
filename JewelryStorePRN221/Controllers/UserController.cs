using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.IService;
using System.Net.Mime;

namespace JewelryStorePRN221.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;
        private readonly IJwtService _jwtService;
        
        public UserController(IUserServices userServices, IJwtService jwtService)
        {
            _userServices = userServices;
            _jwtService = jwtService;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<UserLoginDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<JsonResponse<UserLoginDTO>>> Login(
                       [FromBody] LoginDTO request,
                                  CancellationToken cancellationToken = default)
        {
            var result = _userServices.Login(request, cancellationToken);
            var token = _jwtService.CreateToken(result.Result.ID, result.Result.Role);
            result.Result.Token = token;
            return Ok(result.Result);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("register")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<JsonResponse<string>>> TestJwt(
                       [FromBody] RegisterDTO request,
                                  CancellationToken cancellationToken = default)
        {
            var result = await _userServices.Register(request, cancellationToken);
            return Ok(new JsonResponse<string>(result));
        }

        [HttpDelete("delete/{id}")]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<JsonResponse<string>>> DeleteUser([FromRoute] string id, CancellationToken cancellationToken = default)
        {
            var result = await _userServices.Delete(id, cancellationToken);
            return Ok(new JsonResponse<string>(result));
        }

        [HttpPatch("update/{id}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<JsonResponse<string>>> UpdateUser([FromRoute] string id
            , [FromForm]UserUpdateDTO dto
            , CancellationToken cancellationToken)
        {
            var result = await _userServices.Update(id, dto, cancellationToken);
            return Ok(new JsonResponse<string>(result));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(JsonResponse<UserDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<JsonResponse<UserDTO>>> GetByID([FromRoute] string id, CancellationToken cancellationToken = default)
        {
            var result = await _userServices.GetUser(id, cancellationToken);
            return Ok(new JsonResponse<UserDTO>(result));
        }

        [HttpGet("getAll")]
        [ProducesResponseType(typeof(JsonResponse<List<UserDTO>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<JsonResponse<UserDTO>>> GetAll(CancellationToken cancellationToken = default)
        {
            var result = await _userServices.GetAll(cancellationToken);
            return Ok(new JsonResponse<List<UserDTO>>(result));
        }
    }
}
