namespace _03_RESTFUL_WEBAPI_ProductCatalog.Models.Entities
{
    public interface IProductEntity
    {
        string Category { get; set; }
        string Description { get; set; }
        Guid Id { get; set; }
        string Name { get; set; }
        string PartitionKey { get; set; }
        decimal Price { get; set; }
    }
}