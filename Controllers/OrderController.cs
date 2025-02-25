using Microsoft.AspNetCore.Mvc;
using StoreApp.Models;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    private readonly OrderBLL _orderBLL;

    public OrderController(OrderBLL orderBLL)
    {
        _orderBLL = orderBLL;
    }

    [HttpPost]
    public IActionResult NewOrder([FromBody] Order order)
    {
        try
        {
            _orderBLL.NewOrder(order);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    // Diğer API metotları buraya eklenebilir.
}