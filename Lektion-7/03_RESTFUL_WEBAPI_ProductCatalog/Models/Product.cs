namespace _03_RESTFUL_WEBAPI_ProductCatalog.Models
{
    public class Product : IProduct
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Category { get; set; } = null!;
        public decimal Price { get; set; }
    }
}
