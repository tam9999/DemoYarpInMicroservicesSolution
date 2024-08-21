using Microsoft.AspNetCore.Mvc;

namespace ProductApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private static readonly string[] Products = new[]
    {
        "Clothes", "Bags", "Televisions", "Shoes", "Phone", "Accessories"
    };

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(Products);
    }
}