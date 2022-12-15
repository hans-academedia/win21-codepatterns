using Grpc.Net.Client;

namespace _02_gRPC_Client.Factories;

internal static class ProductClientFactory
{
    public static Product.ProductClient Create(GrpcChannel channel)
    {
        return new Product.ProductClient(channel);
    }
}
