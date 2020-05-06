using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entities;

namespace QuickBuy.Repositorio.Config
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.OrderDate).IsRequired();
            builder.Property(o => o.UserId).IsRequired();
            builder.Property(o => o.ExpectedDeliveryDate).IsRequired();
            builder.Property(o => o.ZipCode).IsRequired().HasMaxLength(20);
            builder.Property(o => o.State).HasMaxLength(50);
            builder.Property(o => o.City).HasMaxLength(50);
            builder.Property(o => o.FullAdress).HasMaxLength(200);
            builder.Property(o => o.AdressNumber).IsRequired();
            builder.Property(o => o.PaymentMethodId).IsRequired();

        }
    }
}
