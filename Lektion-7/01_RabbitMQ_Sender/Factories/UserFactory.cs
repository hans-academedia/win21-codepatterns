using _01_RabbitMQ_Sender.Models;

namespace _01_RabbitMQ_Sender.Factories;

internal static class UserFactory
{
    public static User Create(int id, string firstName, string lastName, string email)
    {
        return new User { Id = id, FirstName = firstName, LastName = lastName, Email = email };
    }
}
