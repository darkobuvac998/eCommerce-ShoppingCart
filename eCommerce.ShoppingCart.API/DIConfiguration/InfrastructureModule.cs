using Autofac;
using eCommerce.ShoppingCart.Application.Abstractions;
using eCommerce.ShoppingCart.Infrastructure.Services;

namespace eCommerce.ShoppingCart.API.DIConfiguration;

public sealed class InfrastructureModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        base.Load(builder);

        builder
            .RegisterType<HttpContextAccessor>()
            .As<IHttpContextAccessor>()
            .InstancePerLifetimeScope();

        builder
            .RegisterType<UserResolveService>()
            .As<IUserResolveService>()
            .InstancePerLifetimeScope();
    }
}
