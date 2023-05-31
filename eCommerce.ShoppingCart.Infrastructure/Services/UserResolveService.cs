using eCommerce.ShoppingCart.Application.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.JsonWebTokens;

namespace eCommerce.ShoppingCart.Infrastructure.Services;

public sealed class UserResolveService : IUserResolveService
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public UserResolveService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public string GetCurrentSessionUserName()
    {
        return _httpContextAccessor!.HttpContext!.User!.Claims!
            .FirstOrDefault(uc => uc.Type == JwtRegisteredClaimNames.Name)!
            .Value;
    }
}
