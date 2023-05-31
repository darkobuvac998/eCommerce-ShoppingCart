﻿using eCommerce.ShoppingCart.Application.Abstractions.Commands;
using MediatR;

namespace eCommerce.ShoppingCart.Application.Abstractions.Handlers;

public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand>
    where TCommand : ICommand { }

public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
    where TCommand : ICommand<TResponse>
    where TResponse : class { }
