using _01_RabbitMQ_Receiver.Models;

namespace _01_RabbitMQ_Receiver.Handlers;

internal static class MessageHandler
{
    public static async Task WriteMessageAsync(User user)
    {
        Console.WriteLine($"- Sending email to {user.Email}...");
        await Task.Delay(3000);
        Console.WriteLine($"- Email sent to {user.Email}.");
    }
}
