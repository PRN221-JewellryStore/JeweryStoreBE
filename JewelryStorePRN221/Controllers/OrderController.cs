using BusinessObjecs.DTOs;
using BusinessObjecs.ResponseModels.Models;
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
        private readonly IOrderService _OrderService;

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

        [HttpGet("GetInCart{id}")]
        public async Task<ActionResult<Order>> GetInCart(string id, CancellationToken cancellationToken = default)
        {
            return Ok(await _OrderService.getOrderInCart(id, cancellationToken));
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
        [HttpGet("get-total-revenue")]
        public async Task<ActionResult<decimal>> gettotalrevenue(CancellationToken cancellationToken = default)
        {
            return Ok(await _OrderService.getTotalRevenue(cancellationToken));
        }

        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpPost("create")]
        public async Task<ActionResult> Create([FromForm] OrderDTO OrderDTO, CancellationToken cancellationToken = default)
        {
            return Ok(await _OrderService.Add(OrderDTO, cancellationToken, HttpContext.User));
        }

        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpPatch("update/{id}")]
        public async Task<ActionResult<OrderDTO>> Update(string id, [FromForm] OrderDTO OrderDTO, CancellationToken cancellationToken = default)
        {
            return Ok(await _OrderService.Update(id, OrderDTO, cancellationToken, HttpContext.User));
        }

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
        public async Task<ActionResult<List<OrderDTO>>> GetByUserId(string userId, CancellationToken cancellationToken = default)
        {
            return Ok(await _OrderService.GetByUserId(userId, cancellationToken));
        }
    }
}
