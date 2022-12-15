namespace _01_DRY.Interfaces.Handlers;

internal interface IMailer
{
    Task<string> SendAsync(string to, string subject, string body);
}
