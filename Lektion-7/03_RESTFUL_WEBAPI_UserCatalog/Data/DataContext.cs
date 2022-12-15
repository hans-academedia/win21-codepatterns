using _03_RESTFUL_WEBAPI_UserCatalog.Dtos;
using Microsoft.EntityFrameworkCore;

namespace _03_RESTFUL_WEBAPI_UserCatalog.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
