using RabbitMQ.Client;
using System.Text;

namespace _01_RabbitMQ_Sender.Factories;
internal class RabbitMQMSenderFactory
{
    public static void Send(ConnectionFactory factory, string queue, string message)
    {
        using var connection = factory.CreateConnection();
        using var channel = connection.CreateModel();
        channel.QueueDeclare(queue: queue, durable: false, exclusive: false, autoDelete: false, arguments: null);

        var body = Encoding.UTF8.GetBytes(message);

        channel.BasicPublish(exchange: "", routingKey: queue, basicProperties: null, body: body);
        Console.WriteLine("Message sent at " + DateTime.Now);
    }
}
