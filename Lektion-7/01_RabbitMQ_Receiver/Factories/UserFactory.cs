using _01_RabbitMQ_Receiver.Models;
using Newtonsoft.Json;

namespace _01_RabbitMQ_Receiver.Factories;

internal static class UserFactory
{
    public static User Convert(string json)
    {
        return JsonConvert.DeserializeObject<User>(json)!;
    }
}
