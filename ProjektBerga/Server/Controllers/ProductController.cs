using Microsoft.AspNetCore.Mvc;
using ProjektBerga.Server.Services.ProductService;
using ProjektBerga.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBerga.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts() 
        {
            return Ok(await productService.GetAllProducts());
        
        }
        [HttpGet("Category/{categoryUrl}")]
        public async Task<ActionResult<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            return Ok(await productService.GetProductsByCategory(categoryUrl));

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id )
        {
            return Ok(await productService.GetProduct(id));
        }

    }
}
