using _03_DIP.Interfaces;
using _03_DIP.Models;
using _03_DIP.Models.Entities;

namespace _03_DIP.Factories
{
    public interface IProductFactory : IFactory
    {
        ProductEntity ProductEntity();
        Product Product(ProductEntity productEntity);
        List<Product> ProductList();
    }

    public class ProductFactory : IProductFactory
    {
        public ProductEntity ProductEntity()
        {
            return new ProductEntity();
        }

        public Product Product(ProductEntity productEntity)
        {
            return new Product()
            {
                Id = productEntity.Id,
                Name = productEntity.Name,
                Price = productEntity.Price
            };
        }

        public List<Product> ProductList()
        {
            return new List<Product>();
        }
    }
}
