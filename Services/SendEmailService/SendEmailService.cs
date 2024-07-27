
using MailKit.Security;
using MimeKit.Text;
using MailKit.Net.Smtp;
using MimeKit;

namespace FinalSendEmail.Services.SendEmailService
{
    public class SendEmailService : ISendEmailService
    {
        private readonly IConfiguration _config;
        public SendEmailService(IConfiguration config)
        {
            _config = config;
        }
        public void SendEmail(EmailDto request)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("bdawolo@gmail.com"));
            email.To.Add(MailboxAddress.Parse(request.recipient));
            email.Subject = request.subject;
            email.Body = new TextPart(TextFormat.Html) { Text = request.body };

            using var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("chrisdawolo@gmail.com", "gkqk rrzp oxje jaks");
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}
