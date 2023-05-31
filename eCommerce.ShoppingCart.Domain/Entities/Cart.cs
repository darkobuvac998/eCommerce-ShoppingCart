namespace eCommerce.ShoppingCart.Domain.Entities;

public class Cart : BaseEntity
{
    public int UserId { get; set; }
    public int? OrderId { get; set; } = null;
    public bool Purchased { get; set; } = false;
    public double TotalPrice { get; set; }
    public string? Note { get; set; }
    public virtual ICollection<CartItem> Items { get; set; }
    public virtual ICollection<Coupons> Coupons { get; set; }
}
