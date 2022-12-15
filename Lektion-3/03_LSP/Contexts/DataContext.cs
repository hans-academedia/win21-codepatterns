using _03_LSP.Models;
using Microsoft.EntityFrameworkCore;

namespace _03_LSP.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HansMattin-Lassei\\Documents\\Utbildning\\WIN21\\win21-codepatterns\\Lektion-3\\03_LSP\\Contexts\\demo_db.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}
