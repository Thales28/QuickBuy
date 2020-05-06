using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entities;
using QuickBuy.Dominio.ValueObject;
using QuickBuy.Repositorio.Config;

namespace QuickBuy.Repositorio.Context
{
    public class QuickBuyContext : DbContext 
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }

        public QuickBuyContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderItemConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentMethodConfiguration());

            modelBuilder.Entity<PaymentMethod>().HasData(new PaymentMethod() {Id = 1, Name = "BankSlip", Description = "BankSlip Payment Method" },
                                                        new PaymentMethod() { Id = 2, Name = "CreditCard", Description = "CreditCard Payment Method" },
                                                        new PaymentMethod() { Id = 3, Name = "Deposit", Description = "Deposit Payment Method" }
                                                        );

            base.OnModelCreating(modelBuilder);
        }
    }
}
