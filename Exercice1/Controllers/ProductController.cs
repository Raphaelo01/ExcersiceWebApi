using Data.DTOs;
using Microsoft.AspNetCore.Mvc;
using ONIS.Business.Interfaces;

namespace Exercice1.Controllers
{
    [Route("api/Product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productServ;
        private readonly ILogger<ProductController> _logger;
        public ProductController(IProductService product, ILogger<ProductController> logger)
        {
            _productServ = product;
            _logger = logger;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProducts()
        {
            _logger.LogError(message: $"Este es un log en el enpoint Product->GetProducts como ejemplo");
            return Ok(await _productServ.GetProducts());
        }

        [HttpGet("{id}", Name = "GetProductById")]
        public async Task<ActionResult<ProductDTO>> GetProductById(int id)
        {
            var product = await _productServ.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpDelete("{id}", Name = "DeleteProductById")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _productServ.DeleteProduct(id);

            return NoContent();
        }



        [HttpPatch("{id}", Name = "UpdateProduct")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] ProductDTO productDTO)
        {
            var currentProduct = _productServ.GetProductById(id);
            if (currentProduct == null)
            {
                return BadRequest();
            }

            await _productServ.UpdateProduct(id, productDTO);

            return NoContent();
        }
    }
}
