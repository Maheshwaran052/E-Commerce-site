using Ecommerce.Core.DTOs.Categories;
using Ecommerce.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _categoryService.GetAllCategories();
            return Ok(categories);
        }

        [HttpGet("{categoryId}")]
        public async Task<IActionResult> GetCategoryById(int categoryId)
        {
            var category = await _categoryService.GetCategoryById(categoryId);
            if (category == null)
                return NotFound();
            return Ok(category);
        }

        [HttpPost]

        public async Task<IActionResult> AddCategory([FromBody] CreateCategoryDto categoryDto)
        {
            var createdCategory = await _categoryService.AddCategory(categoryDto);
            return CreatedAtAction(
                nameof(GetCategoryById),
                new { categoryId = createdCategory.CategoryId }, 
                createdCategory
                );
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory([FromBody] UpdateCategoryDto categoryDto)
        {
            var updatedCategory = await _categoryService.UpdateCategory(categoryDto);
            if (updatedCategory == null)
                return NotFound();
            return Ok(updatedCategory);
        }

        [HttpDelete("{categoryId}")]
        public async Task<IActionResult> DeleteCategory(int categoryId)
        {
            var deleted = await _categoryService.DeleteCategory(categoryId);
            if (!deleted)
                return NotFound();
            return NoContent();
        }
    }
}
