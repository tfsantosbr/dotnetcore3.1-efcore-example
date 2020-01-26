using System.Reflection;
using EFCoreExampleApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExampleApp.Data.Context
{
    public class SampleContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=EFCoreSample;Username=developer;Password=developer");
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}