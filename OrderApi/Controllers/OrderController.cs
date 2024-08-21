using Microsoft.AspNetCore.Mvc;

namespace OrderApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Order> Get()
    {
        var orders = new List<Order>();
        orders.AddRange(new List<Order>
        {
            new Order(1, "Alice", "Laptop"),
            new Order(2, "Bob", "Smartphone"),
            new Order(3, "Charlie", "Tablet"),
            new Order(4, "Diana", "Smartwatch"),
            new Order(5, "Eve", "Headphones"),

        });
        return orders;
    }
}