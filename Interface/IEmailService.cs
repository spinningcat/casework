using System.Threading.Tasks;

namespace exampleapp.Interface
{
    public interface IEmailService
    {
        Task SendEmailAsync(string toEmail, string subject, string body);
    }
}
