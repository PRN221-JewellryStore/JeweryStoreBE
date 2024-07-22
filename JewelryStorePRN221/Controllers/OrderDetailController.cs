using BusinessObjecs.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.IService;
using System.Net.Mime;
using System.Security.Claims;

namespace JewelryStorePRN221.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly IOrderDetailService _OrderDetailService;

        public OrderDetailController(IOrderDetailService OrderDetailService)
        {
            _OrderDetailService = OrderDetailService;
        }

        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDetailDTO>> GetById(string id, CancellationToken cancellationToken = default)
        {
            return Ok(await _OrderDetailService.GetById(id, cancellationToken));
        }

        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpGet("getall")]
        public async Task<ActionResult<List<OrderDetailDTO>>> GetAll(CancellationToken cancellationToken = default)
        {
            return Ok(await _OrderDetailService.GetAll(cancellationToken));
        }

        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpPost("create")]
        public async Task<ActionResult> Create([FromForm] OrderDetailDTO OrderDetailDTO, CancellationToken cancellationToken = default)
        {
            return Ok(await _OrderDetailService.Add(OrderDetailDTO, cancellationToken, HttpContext.User));
        }

        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpPatch("update/{id}")]
        public async Task<ActionResult<OrderDetailDTO>> Update(string id, [FromForm] OrderDetailDTO OrderDetailDTO, CancellationToken cancellationToken = default)
        {
            return Ok(await _OrderDetailService.Update(id, OrderDetailDTO, cancellationToken, HttpContext.User));
        }

        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpDelete("delete/{id}")]
        public async Task<ActionResult<OrderDetailDTO>> Delete(string id, CancellationToken cancellationToken = default)
        {
            return Ok(await _OrderDetailService.Delete(id, cancellationToken, HttpContext.User));
        }
    }
}
