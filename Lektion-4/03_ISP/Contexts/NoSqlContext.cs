using _03_ISP.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace _03_ISP.Contexts
{
    public class NoSqlContext : DbContext
    {
        public NoSqlContext(DbContextOptions<NoSqlContext> options) : base(options)
        {
        }

        public DbSet<ProductCatalogEntity> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCatalogEntity>().ToContainer("Products").HasPartitionKey(x => x.Id);
        }
    }
}
