using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using exampleapp.Interface;

namespace exampleapp.util
{
    public class Email : IEmailService
    {
        public async Task SendEmailAsync(string toEmail, string subject, string body)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.yourmailserver.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("yourusername", "yourpassword"),
                    EnableSsl = true,
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("yourusername@yourdomain.com"),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true,
                };
                mailMessage.To.Add(toEmail);

                await smtpClient.SendMailAsync(mailMessage);
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
