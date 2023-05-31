using Autofac;

namespace eCommerce.ShoppingCart.API.DIConfiguration;

public sealed class ConfigurationModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        base.Load(builder);

        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true)
            .AddJsonFile("appsettings.Development.json", optional: true)
            .Build();

        builder.RegisterInstance<IConfiguration>(configuration);
    }
}
