using eCommerce.ShoppingCart.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.ShoppingCart.Persistance.Configuration;

internal sealed class CouponsConfiguration : IEntityTypeConfiguration<Coupons>
{
    public void Configure(EntityTypeBuilder<Coupons> builder)
    {
        builder.HasKey(e => e.Id);
        builder.HasIndex(e => e.Code).IsUnique();
    }
}
