using Data.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ONIS.Business.Interfaces;
using ONIS.Business.Services;

namespace Exercice1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productServ;
        public ProductController(IProductService product ) { 
            _productServ= product;
        }    
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProducts()
        {
            return Ok(await _productServ.GetProducts());
        }
        
    }
}
