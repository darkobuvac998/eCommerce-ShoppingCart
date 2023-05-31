using eCommerce.ShoppingCart.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.ShoppingCart.Persistance.Configuration;

internal sealed class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
{
    public void Configure(EntityTypeBuilder<CartItem> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasMany(e => e.Discounts).WithOne(d => d.CartItem).OnDelete(DeleteBehavior.Cascade);
    }
}
