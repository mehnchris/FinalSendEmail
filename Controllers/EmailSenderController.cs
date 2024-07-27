using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit.Text;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;

namespace FinalSendEmail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailSenderController : ControllerBase
    {
        private readonly ISendEmailService _sendEmailService;
        public EmailSenderController(ISendEmailService sendEmailService)
        {
            _sendEmailService = sendEmailService;
        }
        [HttpPost]
        public IActionResult SendEmail(EmailDto request)
        {
            _sendEmailService.SendEmail(request);
            return Ok();

        }
    }
}
