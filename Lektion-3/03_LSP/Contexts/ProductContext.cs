using _03_LSP.Models;
using Microsoft.EntityFrameworkCore;

namespace _03_LSP.Contexts
{
    public class ProductContext : DataContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }

        public DbSet<ProductEntity> Products { get; set; }
    }
}
