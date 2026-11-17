using Ecommerce.Core.DTOs;
using Ecommerce.Core.DTOs.Products;

using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Core.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductResponseDto>> GetAllProducts();
        Task<ProductResponseDto?> GetProductById(int productId);
        Task<IEnumerable<ProductWithCategoryDto>> GetAllProductsWithCategory();
        Task<ProductResponseDto> AddProduct(CreateProductDto productDto);
        Task<ProductResponseDto?> UpdateProduct(int productId, UpdateProductDto productDto);
        Task<bool> DeleteProduct(int productId);

    }
}
