using BusinessObjecs.DTOs;
using Microsoft.AspNetCore.Mvc;
using Services.IService;

namespace JewelryStorePRN221.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionController : ControllerBase
    {
        IPromotionService _promotionService;
        PromotionController(IPromotionService promotionService)
        {
            _promotionService = promotionService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PromotionDTO>> GetById(string id)
        {
            return Ok(await _promotionService.GetById(id));
        }
        [HttpGet]
        public async Task<ActionResult<List<PromotionDTO>>> GetAll()
        {
            return Ok(await _promotionService.GetAll());
        }
        [HttpPost]
        public async Task<ActionResult> Create([FromForm] PromotionDTO promotionDTO)
        {
            return Ok(await _promotionService.Add(promotionDTO));
        }
        [HttpPatch]
        public async Task<ActionResult<PromotionDTO>> Update([FromForm] PromotionDTO promotionDTO)
        {
            return Ok(await _promotionService.Update(promotionDTO));
        }
        [HttpDelete]
        public async Task<ActionResult<PromotionDTO>> Delete(string id)
        {
            return Ok(await _promotionService.GetById(id));
        }
    }
}
