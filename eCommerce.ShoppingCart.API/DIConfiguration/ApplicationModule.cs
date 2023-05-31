using Autofac;
using AutoMapper.Contrib.Autofac.DependencyInjection;
using MediatR.Extensions.Autofac.DependencyInjection;
using MediatR.Extensions.Autofac.DependencyInjection.Builder;

namespace eCommerce.ShoppingCart.API.DIConfiguration;

public sealed class ApplicationModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        base.Load(builder);

        var config = MediatRConfigurationBuilder
            .Create(Application.AssemblyReference.Assembly)
            .WithAllOpenGenericHandlerTypesRegistered()
            .WithRegistrationScope(RegistrationScope.Scoped)
            .Build();

        builder.RegisterMediatR(config);

        builder.RegisterAutoMapper(Application.AssemblyReference.Assembly);
    }
}
