using Ecommerce.Core.Interfaces;
using Ecommerce.Core.Services;
using AutoMapper;
using Ecommerce.Core.DTOs.Categories;
using Ecommerce.Core.Entities;
using Ecommerce.Core.DTOs;

namespace ECommerce.Services
{
    public class CategoryService : ICategoryService
    {   private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CategoryResponseDto>> GetAllCategories()
        {
            var categories = await _categoryRepository.GetAllCategories();
            return _mapper.Map<IEnumerable<CategoryResponseDto>>(categories);
        }
        public async Task<CategoryResponseDto?> GetCategoryById(int categoryId)
        {
            var category = await _categoryRepository.GetCategoryById(categoryId);
            if (category == null)
                return null;
            return _mapper.Map<CategoryResponseDto>(category);
        }
        public async Task<IEnumerable<CategoryWithProductsDto>> GetCategoriesWithProductsAndReviews()
        {
            var categories = await _categoryRepository.GetCategoriesWithProductsAndReviews();
            return _mapper.Map<IEnumerable<CategoryWithProductsDto>>(categories);
        }
        public async Task<CategoryResponseDto> AddCategory(CreateCategoryDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);
            var addedCategory = await _categoryRepository.AddCategory(category);
            return _mapper.Map<CategoryResponseDto>(addedCategory);
        }
        public async Task<bool> DeleteCategory(int categoryId)
        {   var existingCategory = await _categoryRepository.GetCategoryById(categoryId);
            if(existingCategory == null)
                return false;
            await _categoryRepository.DeleteCategory(existingCategory);
            return true;
        }
        public async Task<CategoryResponseDto> UpdateCategory(UpdateCategoryDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);
            var updatedCategory = await _categoryRepository.UpdateCategory(category);
            return _mapper.Map<CategoryResponseDto>(updatedCategory);
        }
    }
}
