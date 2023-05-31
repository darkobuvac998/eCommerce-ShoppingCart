using eCommerce.ShoppingCart.Application.Abstractions;
using eCommerce.ShoppingCart.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.ShoppingCart.Persistance.Context;

public class ShoppingCartContext : DbContext
{
    private readonly IUserResolveService _userResolveService;
    private string UserName
    {
        get => _userResolveService.GetCurrentSessionUserName();
    }

    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<Discount> Discounts { get; set; }
    public DbSet<Coupons> Coupons { get; set; }

    public ShoppingCartContext(
        DbContextOptions<ShoppingCartContext> options,
        IUserResolveService userResolveService
    )
        : base(options)
    {
        _userResolveService = userResolveService;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSnakeCaseNamingConvention();
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (
            var entry in base.ChangeTracker
                .Entries<BaseEntity>()
                .Where(e => e.State == EntityState.Modified || e.State == EntityState.Added)
                .ToList()
        )
        {
            entry.Entity.UpdatedAt = DateTime.UtcNow;
            entry.Entity.UpdatedBy = UserName;
            if (entry.State == EntityState.Added)
            {
                entry.Entity.CreateAt = DateTime.UtcNow;
                entry.Entity.CreatedBy = UserName;
            }
        }

        return await base.SaveChangesAsync(cancellationToken);
    }
}
