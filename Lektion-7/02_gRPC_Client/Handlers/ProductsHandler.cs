using _02_gRPC_Client.Factories;
using Grpc.Core;
using Grpc.Net.Client;

namespace _02_gRPC_Client.Handlers;

internal static class ProductsHandler
{
    public static async Task<IEnumerable<ProductResponse>> GetProductsAsync(GrpcChannel channel)
    {
        var products = ProductListFactory.Create();

        var productsClient = ProductClientFactory.Create(channel);
        using var productsReply = productsClient.GetProducts(new ProductEmptyRequest());

        await foreach (var product in productsReply.ResponseStream.ReadAllAsync())
            products.Add(product);

        return products;
    }
}
