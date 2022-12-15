namespace _03_RESTFUL_WEBAPI_ProductCatalog.Models
{
    public class ProductResponse : IProductResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Category { get; set; } = null!;
        public decimal Price { get; set; }
    }
}
