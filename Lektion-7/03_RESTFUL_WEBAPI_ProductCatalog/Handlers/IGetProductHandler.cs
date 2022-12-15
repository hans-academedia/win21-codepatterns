using _03_RESTFUL_WEBAPI_ProductCatalog.Models;

namespace _03_RESTFUL_WEBAPI_ProductCatalog.Handlers
{
    public interface IGetProductHandler
    {
        Task<ProductResponse> Get(Guid id);
    }
}