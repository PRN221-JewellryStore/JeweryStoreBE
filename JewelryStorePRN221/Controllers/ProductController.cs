using BusinessObjecs.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.IService;
using System.Net.Mime;

namespace JewelryStorePRN221.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductService _ProductService;

        public ProductController(IProductService ProductService)
        {
            _ProductService = ProductService;
        }

        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTO>> GetById(string id, CancellationToken cancellationToken = default)
        {
            return Ok(await _ProductService.GetById(id, cancellationToken));
        }

        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpGet]
        public async Task<ActionResult<List<ProductDTO>>> GetAll(CancellationToken cancellationToken = default)
        {
            return Ok(await _ProductService.GetAll(cancellationToken));
        }

        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpPost]
        public async Task<ActionResult> Create([FromForm] ProductDTO ProductDTO, CancellationToken cancellationToken = default)
        {
            return Ok(await _ProductService.Add(ProductDTO, cancellationToken));
        }

        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpPatch("{id}")]
        public async Task<ActionResult<ProductDTO>> Update(string id, [FromForm] ProductDTO ProductDTO, CancellationToken cancellationToken = default)
        {
            return Ok(await _ProductService.Update(id, ProductDTO, cancellationToken));
        }

        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpDelete]
        public async Task<ActionResult<ProductDTO>> Delete(string id, CancellationToken cancellationToken = default)
        {
            return Ok(await _ProductService.Delete(id, cancellationToken));
        }
    }
}
