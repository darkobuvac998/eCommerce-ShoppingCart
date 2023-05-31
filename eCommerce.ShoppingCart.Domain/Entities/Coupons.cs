namespace eCommerce.ShoppingCart.Domain.Entities;

public class Coupons : BaseEntity
{
    public string Code { get; set; }
    public virtual Cart Cart { get; set; }
}
