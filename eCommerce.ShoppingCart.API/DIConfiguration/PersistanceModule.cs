using Autofac;
using eCommerce.ShoppingCart.Application.Abstractions;
using eCommerce.ShoppingCart.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.ShoppingCart.API.DIConfiguration;

public sealed class PersistanceModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        base.Load(builder);

        builder
            .Register(x =>
            {
                var userResolverService = x.Resolve<IUserResolveService>();
                var configuration = x.Resolve<IConfiguration>();

                var optionsBuilder = new DbContextOptionsBuilder<ShoppingCartContext>();
                optionsBuilder
                    .UseNpgsql(
                        configuration.GetConnectionString("Db"),
                        optionsBuilder =>
                        {
                            optionsBuilder
                                .MigrationsAssembly("eCommerce.ShoppingCart.Persistance")
                                .UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
                        }
                    )
                    .EnableSensitiveDataLogging();

                return new ShoppingCartContext(optionsBuilder.Options, userResolverService);
            })
            .InstancePerLifetimeScope();
    }
}
