using Ecommerce.Core.DTOs;
using Ecommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Core.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product?> GetProductById(int productId);
        Task<IEnumerable<ProductWithCategoryDto>> GetAllProductsWithCategory();
        Task<Product> AddProduct(Product product);
        Task<Product> DeleteProduct(Product product);
        Task<Product> UpdateProduct(Product product);
    }
}
