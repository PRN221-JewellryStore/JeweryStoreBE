using BusinessObjecs.Models;
using Microsoft.AspNetCore.Mvc;
using Services.IService;

namespace JewelryStorePRN221.Controllers
{
    [ApiController]
    //[Authorize]
    public class VnPayController : Controller
    {
        private readonly IVnPayService _vnPayService;

        public VnPayController(IVnPayService vnPayService)
        {
            _vnPayService = vnPayService;
        }

        [HttpPost("create-payment-url")]
        public async Task<IActionResult> CreatePaymentUrl([FromBody] PaymentInformationModel model)
        {
            var paymentUrl = _vnPayService.CreatePaymentUrl(model, HttpContext);
            return Ok(Task.FromResult(paymentUrl));
        }

        [HttpGet("payment-callback")]
        public async Task<IActionResult> PaymentCallback()
        {
            var response = _vnPayService.PaymentExecute(Request.Query);
            return Json(Task.FromResult(response));
        }
    }
}
