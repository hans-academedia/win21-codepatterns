using _03_DIP.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace _03_DIP.Contexts
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public DbSet<ProductEntity> Products { get; set; }
    }
}
