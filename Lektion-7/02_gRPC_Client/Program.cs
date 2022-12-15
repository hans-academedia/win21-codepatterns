using Grpc.Net.Client;
using _02_gRPC_Client.Handlers;

Console.WriteLine("Tryck på en valfri tangent för att starta...");
Console.ReadKey();

using var channel = GrpcChannel.ForAddress("https://localhost:7292");

var product = await ProductHandler.GetProductAsync(channel, 1);
Console.WriteLine($"{product.Name} {product.Price} SEK. \n");

var products = await ProductsHandler.GetProductsAsync(channel);
foreach(var item in products)
{
    Console.WriteLine($"{item.Name} {item.Price} SEK.");
}


Console.ReadKey();
