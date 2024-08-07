﻿using BusinessObjecs.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.IService;
using System.Net.Mime;
using System.Security.Claims;

namespace JewelryStorePRN221.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionController : ControllerBase
    {
        private readonly IPromotionService _promotionService;

        public PromotionController(IPromotionService promotionService)
        {
            _promotionService = promotionService;
        }

        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpGet("{id}")]
        public async Task<ActionResult<PromotionDTO>> GetById(string id, CancellationToken cancellationToken = default)
        {
            return Ok(await _promotionService.GetById(id, cancellationToken));
        }

        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpGet("getall")]
        public async Task<ActionResult<List<PromotionDTO>>> GetAll(CancellationToken cancellationToken = default)
        {
            return Ok(await _promotionService.GetAll(cancellationToken));
        }

        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpPost("create")]
        public async Task<ActionResult> Create([FromForm] PromotionDTO promotionDTO, CancellationToken cancellationToken = default)
        {
            return Ok(await _promotionService.Add(promotionDTO, cancellationToken));
        }

        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpPatch("update/{id}")]
        public async Task<ActionResult<PromotionDTO>> Update(string id, [FromForm] PromotionDTO promotionDTO, CancellationToken cancellationToken = default)
        {
            return Ok(await _promotionService.Update(id, promotionDTO, cancellationToken));
        }

        [AllowAnonymous]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(JsonResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [HttpDelete("delete/{id}")]
        public async Task<ActionResult<PromotionDTO>> Delete(string id, CancellationToken cancellationToken = default)
        {
            
            return Ok(await _promotionService.Delete(id, cancellationToken, HttpContext.User));
        }
    }
}
