using Autofac;
using Autofac.Extensions.DependencyInjection;
using eCommerce.ShoppingCart.API.DIConfiguration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Host
    .UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(builder =>
    {
        builder.RegisterModule(new ShoppingCartModule());
    });

builder.Services
    .AddControllers()
    .AddApplicationPart(eCommerce.ShoppingCart.Application.AssemblyReference.Assembly);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
