using BusinessObjecs.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.IRepository;
using Services.IService;

namespace JewelryStorePRN221.Controllers
{
    [ApiController]
    //[Authorize]
    public class VnPayController : Controller
    {
        private readonly IVnPayService _vnPayService;
        private readonly IEmailService _emailService;
        private readonly IUserServices _userService;

        public VnPayController(IVnPayService vnPayService, IEmailService emailService, IUserServices userService)
        {
            _vnPayService = vnPayService;
            _emailService = emailService;
            _userService = userService;
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

        [HttpGet("send-email")]
        public async Task<IActionResult> SendTestEmail(string email, CancellationToken cancellationToken)
        {
            try
            {
                await _userService.SendEmailCustomer(email, cancellationToken);
                return Ok(new { message = "Test email sent successfully." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Failed to send test email.", error = ex.Message });
            }
        }
    }
}
