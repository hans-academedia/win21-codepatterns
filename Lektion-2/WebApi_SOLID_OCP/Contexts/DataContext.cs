using Microsoft.EntityFrameworkCore;
using WebApi_SOLID_OCP.Models.Entitites;

namespace WebApi_SOLID_OCP.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<UserAccountEntity> UserAccounts { get; set; }
        public DbSet<UserAccountProfileEntity> UserAccountProfiles { get; set; }
        public DbSet<AdminAccountRoleEntity> AdminAccountRoles { get; set; }
        public DbSet<AdminAccountEntity> AdminAccounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAccountEntity>()
                .HasKey(x => x.Id);
            
            modelBuilder.Entity<UserAccountEntity>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<UserAccountEntity>()
                .HasOne(x => x.UserProfile)
                .WithOne(x => x.UserAccount)
                .HasForeignKey<UserAccountProfileEntity>(x => x.UserId);

            modelBuilder.Entity<UserAccountProfileEntity>()
                .HasKey(x => x.UserId);

            modelBuilder.Entity<AdminAccountEntity>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<AdminAccountEntity>()
                .HasIndex(u => u.Email)
                .IsUnique();
        }
    }
}
