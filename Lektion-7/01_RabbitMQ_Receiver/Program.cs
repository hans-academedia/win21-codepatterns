using _01_RabbitMQ_Receiver.Factories;

Console.WriteLine("Receiving messages...");
var factory = RabbitMQFactory.Create("localhost");
RabbitMQReceiverFactory.Receive(factory, "users");