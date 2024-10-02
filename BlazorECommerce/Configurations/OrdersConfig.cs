using BlazorECommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorECommerce.Configurations;

public class OrdersConfig : IEntityTypeConfiguration<Orders>
{
    public void Configure(EntityTypeBuilder<Orders> builder)
    {
        builder.HasKey(x => x.IdOrder);
        builder.Property(x => x.IdOrder).ValueGeneratedOnAdd().UseIdentityColumn();
        builder.Property(x => x.OrderDate).HasColumnType("datetime").IsRequired();
        

    }
}