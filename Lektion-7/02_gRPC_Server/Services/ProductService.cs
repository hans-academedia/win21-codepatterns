using _02_gRPC_Server.Models;
using Grpc.Core;

namespace _02_gRPC_Server.Services;

public class ProductService : Product.ProductBase, IProductService
{
    private List<IProductModel> products = new List<IProductModel>()
    {
        new ProductModel {  Id = 1, Name = "Product 1", Description= "Description for product 1", Price = 1000},
        new ProductModel {  Id = 2, Name = "Product 2", Description= "Description for product 2", Price = 1000},
        new ProductModel {  Id = 3, Name = "Product 3", Description= "Description for product 3", Price = 1000},
    };


    public override Task<ProductResponse> GetProduct(ProductRequest request, ServerCallContext context)
    {
        var product = products.FirstOrDefault(x => x.Id == request.Id);
        if (product != null)
        {
            var productResponse = new ProductResponse
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price
            };

            return Task.FromResult(productResponse);
        }
        return null!;
    }

    public override async Task GetProducts(ProductEmptyRequest req, IServerStreamWriter<ProductResponse> res, ServerCallContext context)
    {
        foreach (var product in products)
        {
            var productResponse = new ProductResponse
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price
            };

            await res.WriteAsync(productResponse);
        }
    }
}
