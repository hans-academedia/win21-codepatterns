using _01_RabbitMQ_Sender.Factories;

var factory = RabbitMQFactory.Create("localhost");

while (true)
{
    var message = RabbitMQMessageFactory.CreateMessage(1, "Hans", "Mattin-Lassei", "hans@domain.com");
    RabbitMQMSenderFactory.Send(factory, "users", message);

    Console.WriteLine("Press any key to send a message again.");
    Console.ReadLine();
}
