using Newtonsoft.Json;

namespace _01_RabbitMQ_Sender.Factories;

internal static class RabbitMQMessageFactory
{
    public static string CreateMessage(int id, string firstName, string lastName, string email)
    {
        return JsonConvert.SerializeObject(UserFactory.Create(id, firstName, lastName, email));
    }
}
