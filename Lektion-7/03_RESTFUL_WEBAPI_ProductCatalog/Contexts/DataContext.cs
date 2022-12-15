using _03_RESTFUL_WEBAPI_ProductCatalog.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace _03_RESTFUL_WEBAPI_ProductCatalog.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<ProductEntity> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductEntity>().ToContainer("Products").HasPartitionKey(x => x.PartitionKey);
        }
    }
}
