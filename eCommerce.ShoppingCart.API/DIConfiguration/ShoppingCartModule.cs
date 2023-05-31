using Autofac;

namespace eCommerce.ShoppingCart.API.DIConfiguration;

public sealed class ShoppingCartModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        base.Load(builder);

        builder.RegisterModule<InfrastructureModule>();
        builder.RegisterModule<PersistanceModule>();
        builder.RegisterModule<ConfigurationModule>();
        builder.RegisterModule<ApplicationModule>();
    }
}
