using Ecommerce.Core.DTOs.Categories;
using Ecommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Core.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryResponseDto>> GetAllCategories();
        Task<CategoryResponseDto?> GetCategoryById(int categoryId);
        Task<CategoryResponseDto> AddCategory(CreateCategoryDto category);
        Task<bool> DeleteCategory(int categoryId);
        Task<CategoryResponseDto> UpdateCategory(UpdateCategoryDto category);
    }
}
