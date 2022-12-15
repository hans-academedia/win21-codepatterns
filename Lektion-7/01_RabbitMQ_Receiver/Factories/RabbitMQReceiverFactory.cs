using _01_RabbitMQ_Receiver.Handlers;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace _01_RabbitMQ_Receiver.Factories;

internal static class RabbitMQReceiverFactory
{
    public static void Receive(ConnectionFactory factory, string queue)
    {
        using var connection = factory.CreateConnection();
        using var channel = connection.CreateModel();
        channel.QueueDeclare(queue: queue, durable: false, exclusive: false, autoDelete: false, arguments: null);

        var consumer = new EventingBasicConsumer(channel);
        consumer.Received += (model, ea) =>
        {
            Console.WriteLine("Message received at " + DateTime.Now);
            var message = Encoding.UTF8.GetString(ea.Body.ToArray());
            var user = UserFactory.Convert(message);

            MessageHandler.WriteMessageAsync(user).ConfigureAwait(false);
        };
        channel.BasicConsume(queue: queue, autoAck: true, consumer: consumer);

        Console.ReadLine();
    }
}
