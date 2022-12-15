using _02_gRPC_Client.Factories;
using Grpc.Net.Client;

namespace _02_gRPC_Client.Handlers;

internal static class ProductHandler
{
    public static async Task<ProductResponse> GetProductAsync(GrpcChannel channel, int id)
    {
        var productClient = ProductClientFactory.Create(channel);
        return await productClient.GetProductAsync(new ProductRequest { Id = id });
    }
}
