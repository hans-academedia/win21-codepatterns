using System.Diagnostics;
using _01_DRY.Factories;
using _01_DRY.Interfaces.Handlers;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;

namespace _01_DRY.Handlers;

internal class Mailer : IMailer
{
    private string from;
    private string smtp;
    private int port;
    private string userAccount;
    private string userAccountPassword;

    public Mailer(string from, string smtp, int port, string userAccount, string userAccountPassword)
    {
        this.from = from;
        this.smtp = smtp;
        this.port = port;
        this.userAccount = userAccount;
        this.userAccountPassword = userAccountPassword;
    }

    public async Task<string> SendAsync(string to, string subject, string body)
    {
        try
        {
            var email = GenericFactory.Create<MimeMessage>();
            email.From.Add(MailboxAddress.Parse(from));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = body };

            using var client = GenericFactory.Create<SmtpClient>();
            await client.ConnectAsync(smtp, port, SecureSocketOptions.StartTls);
            await client.AuthenticateAsync(userAccount, userAccountPassword);

            var result = await client.SendAsync(email);
            await client.DisconnectAsync(true);
            return result;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return string.Empty;
        }
    }
}
