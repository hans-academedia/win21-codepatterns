using _02_DRY.Handlers;
using _02_DRY.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _02_DRY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmsController : ControllerBase
    {
        private readonly ISmsHandler _smsHandler;

        public SmsController(ISmsHandler smsHandler)
        {
            _smsHandler = smsHandler;
        }

        [HttpPost]
        public async Task<IActionResult> Send(SmsRequest req)
        {
            var result = await _smsHandler.SendSMSAsync(req.To, req.Message);
            return new OkObjectResult(result);
        }
    }
}
