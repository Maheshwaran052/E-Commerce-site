
using Ecommerce.Core.Entities;
using Ecommerce.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/Product
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var productList = await _productService.GetAllProducts();
            return Ok(productList);
        }

        // GET: api/Product/1
        [HttpGet("{productId}")]
        public async Task<IActionResult> GetProductById(int productId)
        {
            var product = await _productService.GetProductById(productId);

            if (product == null)
            {
                return NotFound("Product not found");
            }

            return Ok(product);
        }

        // POST: api/Product
        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] Product product)
        {
            var createdProduct = await _productService.AddProduct(product);

            return Ok(createdProduct);
        }

        // PUT: api/Product/1
        [HttpPut("{productId}")]
        public async Task<IActionResult> UpdateProduct(
            int productId,
            [FromBody] Product product)
        {
            var existingProduct = await _productService.GetProductById(productId);
            if (existingProduct == null)
            {
                return NotFound("Product not found");
            }
            if (product.ProductId != productId)
            {
                return BadRequest("Product ID mismatch");
            }
            var updatedProduct = await _productService.UpdateProduct(product);
            return Ok(updatedProduct);
        }

        // DELETE: api/Product/1
        [HttpDelete("{productId}")]
        public async Task<IActionResult> DeleteProduct(int productId)
        {
            var product = await _productService.GetProductById(productId);

            if (product == null)
            {
                return NotFound("Product not found");
            }
            await _productService.DeleteProduct(product);
            return NoContent();
        }
    }
}
