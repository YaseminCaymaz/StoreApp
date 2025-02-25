using Microsoft.AspNetCore.Mvc;
using StoreApp.Models;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    private readonly CustomerBLL _customerBLL;


    public CustomerController(  CustomerBLL  customerBLL   )
    {
        _customerBLL = customerBLL;
    }

    [HttpPost]
    public IActionResult NewCustomer([FromBody] Customer customer)
    {
        try
        {
            _customerBLL.NewCustomer(   customer   );
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    // Diğer API metotları buraya eklenebilir.
}