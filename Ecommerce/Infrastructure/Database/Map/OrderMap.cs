using Ecommerce.Infrastructure.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Database.Map
{
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order", "Ecommerce");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.OrderDate).IsRequired();
            builder.Property(p => p.TotalOrder).IsRequired();
        }
        
    }
}
