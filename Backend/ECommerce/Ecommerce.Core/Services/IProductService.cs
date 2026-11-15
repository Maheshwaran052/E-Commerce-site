using Ecommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Core.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product?> GetProductById(int productId);
        Task<Product> AddProduct(Product product);
        Task<Product> DeleteProduct(Product product);
        Task<Product> UpdateProduct(Product product);

    }
}
