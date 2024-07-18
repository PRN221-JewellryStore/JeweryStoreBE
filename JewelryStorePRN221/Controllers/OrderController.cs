using BusinessObjecs.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.IService;
using System.Net.Mime;

namespace JewelryStorePRN221.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IOrderService _OrderService;

        public OrderController(IOrderService OrderService)
        {
            _OrderService = OrderService;
        }

        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDTO>> GetById(string id, CancellationToken cancellationToken = default)
        {
            return Ok(await _OrderService.GetById(id, cancellationToken));
        }

        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpGet("getall")]
        public async Task<ActionResult<List<OrderDTO>>> GetAll(CancellationToken cancellationToken = default)
        {
            return Ok(await _OrderService.GetAll(cancellationToken));
        }

        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpPost("create")]
        public async Task<ActionResult> Create([FromForm] OrderDTO OrderDTO, CancellationToken cancellationToken = default)
        {
            return Ok(await _OrderService.Add(OrderDTO, cancellationToken));
        }

        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpPatch("update/{id}")]
        public async Task<ActionResult<OrderDTO>> Update(string id, [FromForm] OrderDTO OrderDTO, CancellationToken cancellationToken = default)
        {
            return Ok(await _OrderService.Update(id, OrderDTO, cancellationToken));
        }

        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpDelete("delete/{id}")]
        public async Task<ActionResult<OrderDTO>> Delete(string id, CancellationToken cancellationToken = default)
        {
            return Ok(await _OrderService.Delete(id, cancellationToken, HttpContext.User));
        }

        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpGet("user:{userId}")]
        public async Task<ActionResult<OrderDTO>> GetByUserId(string userId, CancellationToken cancellationToken = default)
        {
            return Ok(await _OrderService.GetById(userId, cancellationToken));
        }
    }
}
