using _03_ISP.Interfaces;

namespace _03_ISP.Models.Entities
{
    public class ProductCatalogEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public IProductItem ProductInformation { get; set; }
    }
}
