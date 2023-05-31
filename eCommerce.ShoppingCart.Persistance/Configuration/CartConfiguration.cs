using eCommerce.ShoppingCart.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.ShoppingCart.Persistance.Configuration;

internal sealed class CartConfiguration : IEntityTypeConfiguration<Cart>
{
    public void Configure(EntityTypeBuilder<Cart> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Note).HasMaxLength(512);
        builder.Property(e => e.Purchased).HasDefaultValue(false);
        builder.Property(e => e.TotalPrice).HasDefaultValue(0);

        builder.HasMany(e => e.Items).WithOne(e => e.Cart).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(e => e.Coupons).WithOne(e => e.Cart).OnDelete(DeleteBehavior.Cascade);
    }
}
