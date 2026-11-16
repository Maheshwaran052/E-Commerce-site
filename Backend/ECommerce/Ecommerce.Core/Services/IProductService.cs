using Ecommerce.Core.DTOs.Products;
using Ecommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Core.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductResponseDto>> GetAllProducts();
        Task<ProductResponseDto?> GetProductById(int productId);
        Task<ProductResponseDto> AddProduct(CreateProductDto productDto);
        Task<ProductResponseDto?> UpdateProduct(int productId, UpdateProductDto productDto);
        Task<bool> DeleteProduct(int productId);

    }
}
