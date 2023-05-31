namespace eCommerce.ShoppingCart.Domain.Entities;

public class Discount : BaseEntity
{
    public string? Code { get; set; }
    public double? Amount { get; set; }
    public double? Percentage { get; set; }
    public virtual CartItem CartItem { get; set; }
}
