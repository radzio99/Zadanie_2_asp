using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[Route("api/products")]
[ApiController]
public class ProductsController : ControllerBase
{
  
    [HttpGet]
    public IActionResult GetProducts()
    {
       
        List<Product> products = 
        return Ok(products);
    }

   
    [HttpGet("{productId}")]
    public IActionResult GetProduct(int productId)
    {
        
        Product product = 
        if (product == null)
        {
            return NotFound(); 
        }
        return Ok(product);
    }

   
    [HttpPost]
    public IActionResult AddProduct([FromBody] Product product)
    {
       
        return Created("url_do_nowego_produktu", product);
    }

 
    [HttpPut("{productId}")]
    public IActionResult UpdateProduct(int productId, [FromBody] Product product)
    {
       
        return NoContent();
    }

    
    [HttpDelete("{productId}")]
    public IActionResult DeleteProduct(int productId)
    {
        
        return NoContent();
    }
}
