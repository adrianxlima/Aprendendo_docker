using Ecommerce.Infrastructure.Database.Entities;
using Ecommerce.Infrastructure.Database.Map;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.Database
{
    public class Context : DbContext
    {
        public DbSet<Order> Order { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = Environment.GetEnvironmentVariable("DBCONN");
            optionsBuilder.UseNpgsql(connectionString, options =>
            {
                options.MigrationsHistoryTable("_MigrationHistory", "Ecommerce");
                AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);



            });

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrderMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
