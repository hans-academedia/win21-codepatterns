namespace _03_RESTFUL_WEBAPI_ProductCatalog.Models
{
    public interface IProduct
    {
        string Category { get; set; }
        string Description { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
    }
}