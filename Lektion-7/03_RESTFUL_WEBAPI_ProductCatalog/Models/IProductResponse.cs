namespace _03_RESTFUL_WEBAPI_ProductCatalog.Models
{
    public interface IProductResponse
    {
        string Category { get; set; }
        string Description { get; set; }
        Guid Id { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
    }
}