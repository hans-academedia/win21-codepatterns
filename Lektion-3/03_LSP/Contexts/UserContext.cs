using _03_LSP.Models;
using Microsoft.EntityFrameworkCore;

namespace _03_LSP.Contexts
{
    public class UserContext : DataContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<UserProfileEntity> UserProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<UserEntity>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<UserEntity>()
                .HasOne(x => x.Profile)
                .WithOne(x => x.User)
                .HasForeignKey<UserProfileEntity>(x => x.UserId);

            modelBuilder.Entity<UserProfileEntity>()
                .HasKey(x => x.UserId);

        }
    }
}
