namespace eCommerce.ShoppingCart.Application.Responses.Cart;

public sealed class CartResponse
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int? OrderId { get; set; } = null;
    public bool Purchased { get; set; } = false;
    public double TotalPrice { get; set; }
    public string? Note { get; set; }
    public DateTime CreateAt { get; set; }
}
