using _01_DRY.Handlers;

namespace _01_DRY.Factories;

internal static class MailerFactory
{
    public static Mailer Create(string from, string smtp, int port, string userAccount, string userAccountPassword)
    {
        return new Mailer(from, smtp, port, userAccount, userAccountPassword);
    }
}
