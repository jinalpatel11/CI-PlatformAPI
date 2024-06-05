namespace CIPlatform_Web_API.Service
{
    using MimeKit;
    using System;
    using System.Threading.Tasks;

    public class EmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(string toEmail, string subject, string body)
        {
            try
            {
                var emailConfig = _configuration.GetSection("EmailConfiguration");
                var smtpServer = emailConfig["SmtpServer"];
                var smtpPort = int.Parse(emailConfig["SmtpPort"]);
                var smtpUsername = emailConfig["SmtpUsername"];
                var smtpPassword = emailConfig["SmtpPassword"];

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Your Name", smtpUsername));
                message.To.Add(new MailboxAddress("", toEmail));
                message.Subject = subject;

                // Rest of the EmailService code...
            }
            catch (Exception ex)
            {
                // Handle exceptions, log errors, etc.
                throw ex;
            }
        }
    }


}
