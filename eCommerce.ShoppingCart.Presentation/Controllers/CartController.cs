using AutoMapper;
using eCommerce.ShoppingCart.Persistance.Context;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Products.Presentation.Controllers;

[Route("/api/[controller]")]
public sealed class CartController : ApiController
{
    private readonly ShoppingCartContext _cartContext;

    public CartController(ISender sender, IMapper mapper, ShoppingCartContext cartContext)
        : base(sender, mapper)
    {
        _cartContext = cartContext;
    }

    [HttpGet]
    public async Task<IActionResult> GetCartsAsync()
    {
        return Ok("Hello");
    }
}
