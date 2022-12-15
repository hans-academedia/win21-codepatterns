using RabbitMQ.Client;

namespace _01_RabbitMQ_Receiver.Factories;

internal static class RabbitMQFactory
{
    public static ConnectionFactory Create(string hostName)
    {
        return new ConnectionFactory() { HostName = hostName };
    }
}
