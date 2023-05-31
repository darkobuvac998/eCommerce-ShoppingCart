using MediatR;

namespace eCommerce.ShoppingCart.Application.Abstractions.Commands;

public interface ICommand : IRequest { }

public interface ICommand<out TResponse> : IRequest<TResponse>
    where TResponse : class { }
