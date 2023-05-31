using eCommerce.Products.Application.Abstractions.Handlers;
using eCommerce.ShoppingCart.Application.Queries;
using eCommerce.ShoppingCart.Application.Responses.Cart;

namespace eCommerce.ShoppingCart.Application.Handlers.Cart.Queries;

public sealed class GetShoppingCartsQueryHandler
    : IQueryHandler<GetShoppingCartsQuery, ICollection<CartResponse>>
{
    public GetShoppingCartsQueryHandler() { }

    public Task<ICollection<CartResponse>> Handle(
        GetShoppingCartsQuery request,
        CancellationToken cancellationToken
    )
    {
        throw new NotImplementedException();
    }
}
