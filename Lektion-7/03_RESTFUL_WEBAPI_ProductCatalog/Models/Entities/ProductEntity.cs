﻿namespace _03_RESTFUL_WEBAPI_ProductCatalog.Models.Entities
{
    public class ProductEntity : IProductEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Category { get; set; } = null!;
        public decimal Price { get; set; }
        public string PartitionKey { get; set; } = "Product";

    }
}
