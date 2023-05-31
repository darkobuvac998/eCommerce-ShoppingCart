namespace eCommerce.ShoppingCart.Domain.Entities;

public class CartItem : BaseEntity
{
    public int ProductId { get; set; }
    public double Quantity { get; set; }
    public virtual Cart Cart { get; set; }
    public virtual ICollection<Discount> Discounts { get; set; }
}
