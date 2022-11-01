using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StationeryPlus.Server.Data;

namespace StationeryPlus.Server.Controllers
{ 
    [ApiController] 
    [Route("api/[controller]")] // name used to access controller
    
    public class ProductController : ControllerBase 
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
        {
            var result = await _productService.GetProductsAsync();
            return Ok(result);
        }

        [HttpGet("{productId}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProduct(int productId)
        {
            var result = await _productService.GetProductsAsync(productId);
            return Ok(result);
        }

    }
}