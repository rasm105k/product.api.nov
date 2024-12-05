using InfitinityElectronics.Web.Services;
using InfitinityElectronics.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace InfitinityElectronics.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController(ILogger<ProductController> logger, IProductService productService) : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetProduct([FromRoute] string? id)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id))
                    return BadRequest("Please input valid id");

                var product = productService.GetProduct(id);
                return Ok(product);
            }
            catch (Exception e)
            {
                logger.LogError(e, "Failed to get product {ProductId}", id);
                return StatusCode(500, $"Failed to get product {id}");
            }
        }

        [HttpGet("list")]
        public IActionResult GetProducts([FromQuery] int currentPage = 1, [FromQuery] int pageSize = 10, [FromQuery] string? categoryId = null)
        {
            try
            {
                List<ProductViewModel> products = productService.GetProducts(currentPage, pageSize, categoryId);
                return Ok(products);
            }
            catch (Exception e)
            {
                logger.LogError(e, "Failed to get products");
                return StatusCode(500, $"Failed to get products");
            }
        }
    }
}
