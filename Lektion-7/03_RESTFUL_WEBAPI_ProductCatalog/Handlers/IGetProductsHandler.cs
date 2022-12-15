using _03_RESTFUL_WEBAPI_ProductCatalog.Models;

namespace _03_RESTFUL_WEBAPI_ProductCatalog.Handlers
{
    public interface IGetProductsHandler
    {
        Task<IEnumerable<ProductResponse>> Get();
    }
}