using BusinessObjecs.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.IRepository;
using Services.IService;

namespace JewelryStorePRN221.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class VnPayController : Controller
    {
        private readonly IVnPayService _vnPayService;
        private readonly IEmailService _emailService;
        private readonly IUserServices _userService;
        private readonly IOrderService _orderService;

        public VnPayController(IVnPayService vnPayService, IEmailService emailService, IUserServices userService,IOrderService orderService)
        {
            _vnPayService = vnPayService;
            _emailService = emailService;
            _userService = userService;
            _orderService = orderService;
        }

        [HttpPost("create-payment-url")]
        public async Task<IActionResult> CreatePaymentUrl([FromBody] PaymentInformationModel model)
        {
            var paymentUrl = _vnPayService.CreatePaymentUrl(model, HttpContext);
            return Ok(Task.FromResult(paymentUrl));
        }

        [HttpGet("payment-callback/")]
        public async Task<IActionResult> PaymentCallback([FromQuery] string userid, CancellationToken cancellationToken)
        {
            var response = _vnPayService.PaymentExecute(Request.Query);
            var paymentResponseModel = response;
            await _orderService.UpdateOrderStatusAfterPaymentAsync(response, userid, cancellationToken);

            return Json(Task.FromResult(response));
        }

        [HttpPost("send-email")]
        public async Task<IActionResult> SendTestEmail(string email, CancellationToken cancellationToken)
        {
            try
            {
                await _userService.SendEmailCustomer(email, cancellationToken);
                return Ok(new { message = "email sent successfully." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Failed to send test email.", error = ex.Message });
            }
        }
    }
}
