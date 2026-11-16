using Ecommerce.Core.DTOs.Products;
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
            var products = await _productService.GetAllProducts();
            return Ok(products);
        }

        // GET: api/Product/1
        [HttpGet("{productId}")]
        public async Task<IActionResult> GetProductById(int productId)
        {
            var product = await _productService.GetProductById(productId);
            if (product == null)
                return NotFound("Product not found");
            return Ok(product);
        }

        // POST: api/Product
        [HttpPost]
        public async Task<IActionResult> AddProduct(
            [FromBody] CreateProductDto productDto)
        {
            var createdProduct =
                await _productService.AddProduct(productDto);

            return CreatedAtAction(
              nameof(GetProductById),
              new {productId = createdProduct.ProductId},
              createdProduct
            );
        }

        // PUT: api/Product/1
        [HttpPut("{productId}")]
        public async Task<IActionResult> UpdateProduct(
            int productId,
            [FromBody] UpdateProductDto productDto)
        {
            var updatedProduct =
                await _productService.UpdateProduct(productId, productDto);

            if (updatedProduct == null)
                return NotFound("Product not found");

            return Ok(updatedProduct);
        }

        // DELETE: api/Product/1
        [HttpDelete("{productId}")]
        public async Task<IActionResult> DeleteProduct(int productId)
        {
            var deleted = await _productService.DeleteProduct(productId);

            if (!deleted)
                return NotFound("Product not found");

            return NoContent();
        }
    }
}
