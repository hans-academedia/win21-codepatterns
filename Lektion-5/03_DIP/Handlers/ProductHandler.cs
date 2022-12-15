using _03_DIP.Contexts;
using _03_DIP.Factories;
using _03_DIP.Models;
using _03_DIP.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _03_DIP.Handlers
{
    public interface IProductHandler
    {
        Task CreateAsync(ProductRequest req);
        Task<IEnumerable<Product>> GetAllAsync();
        Task<ProductEntity> GetAsync(int id);

    }


    public class ProductHandler : IProductHandler
    {
        private readonly NoSqlContext _nosql;
        private readonly SqlContext _sql;
        private readonly IProductFactory _factory;

        public ProductHandler(NoSqlContext nosql, SqlContext sql, IProductFactory factory)
        {
            _nosql = nosql;
            _sql = sql;
            _factory = factory;
        }

        public async Task CreateAsync(ProductRequest req)
        {
            var productEntity = _factory.ProductEntity();
            productEntity.Name = req.Name;
            productEntity.Price = req.Price;
            
            _sql.Add(productEntity);
            await _sql.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            List<Product> products = _factory.ProductList();
            
            foreach (var productEntity in await _sql.Products.ToListAsync())
                products.Add(_factory.Product(productEntity));

            return products;
        }

        public Task<ProductEntity> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
