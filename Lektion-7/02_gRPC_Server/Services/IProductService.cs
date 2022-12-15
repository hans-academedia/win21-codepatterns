using Grpc.Core;

namespace _02_gRPC_Server.Services;

public interface IProductService
{
    Task<ProductResponse> GetProduct(ProductRequest request, ServerCallContext context);
    Task GetProducts(ProductEmptyRequest req, IServerStreamWriter<ProductResponse> res, ServerCallContext context);
}