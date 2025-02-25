using Microsoft.AspNetCore.Mvc;
using StoreApp.Models;

[ApiController]
[Route("api/product")]
public class ProductController : ControllerBase
{
    private readonly ProductBLL _productBLL;

    public ProductController(ProductBLL productBLL)
    {
        _productBLL = productBLL;
    }

    [HttpPost]
    public IActionResult NewProduct([FromBody] Product product)
    {
        try
        {
            _productBLL.NewProduct(product);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    // Diğer API metotları buraya eklenebilir.
}