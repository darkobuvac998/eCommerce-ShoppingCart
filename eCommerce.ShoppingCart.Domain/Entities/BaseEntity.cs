namespace eCommerce.ShoppingCart.Domain.Entities;

public class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string CreatedBy { get; set; }
    public string UpdatedBy { get; set; }
}
