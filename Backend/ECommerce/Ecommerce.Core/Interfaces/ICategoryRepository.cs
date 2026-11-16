using Ecommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Core.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategories();
        Task<Category?> GetCategoryById(int categoryId);
        Task<Category> AddCategory(Category category);
        Task<Category> DeleteCategory(Category category);
        Task<Category> UpdateCategory(Category category);
    }
}
