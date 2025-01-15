using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MobileRepair.Data.Configurations;
using MobileRepair.Data.Models;

namespace MobileRepair.Data
{
    public class ApplicationDbContext : IdentityDbContext<
        ApplicationUser,
        IdentityRole<int>,
        int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderHistory> OrdersHistory { get; set; }
        public DbSet<OrderService> OrderServices { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Service> Services { get; set; }
        
         
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                         .SelectMany(t => t.GetProperties())
                         .Where(p => p.ClrType == typeof(DateTime)))
            {
                property.SetColumnType("timestamp");
            }

            modelBuilder.ApplyConfiguration(new OrderServiceConfiguration());
            modelBuilder.ApplyConfiguration(new DeviceConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderHistoryConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentConfiguration());

            modelBuilder.AddServices()
                .AddRoles();

            base.OnModelCreating(modelBuilder);
        }
    }
}
