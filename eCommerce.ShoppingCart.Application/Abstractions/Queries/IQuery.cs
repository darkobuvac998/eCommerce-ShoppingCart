using MediatR;

namespace eCommerce.ShoppingCart.Application.Abstractions.Queries;

public interface IQuery<out TResponse> : IRequest<TResponse> { }
