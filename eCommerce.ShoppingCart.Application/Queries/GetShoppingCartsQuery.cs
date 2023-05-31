using eCommerce.ShoppingCart.Application.Abstractions.Queries;
using eCommerce.ShoppingCart.Application.Responses.Cart;

namespace eCommerce.ShoppingCart.Application.Queries;

public sealed record GetShoppingCartsQuery() : IQuery<ICollection<CartResponse>>;
