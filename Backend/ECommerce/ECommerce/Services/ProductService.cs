using Ecommerce.Core.Entities;
using Ecommerce.Core.Interfaces;
using Ecommerce.Core.Services;

namespace ECommerce.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            try
            {
                var products = await _productRepository.GetAllProducts();
                return products;
            }
            catch (Exception )
            {
                throw ;
            }
        }
        public async Task<Product?> GetProductById(int productId)
        {
            try
            {
                var product = await _productRepository.GetProductById(productId);
                if (product == null) 
                { 
                    return null; 
                }
                return product;
            }
            catch(Exception )
            { 
                throw ;
            
            }
        }
        public async Task<Product> AddProduct(Product product) 
        {
            try 
            {
                return await _productRepository.AddProduct(product);
            }
            catch(Exception )
            {
                throw ;
            }
        }
        public async Task<Product> DeleteProduct(Product product)
        {
            try
            {
                return await _productRepository.DeleteProduct(product);
            }
            catch (Exception )
            {
                throw ;
            }
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            try
            {
                return await _productRepository.UpdateProduct(product);
            }
            catch (Exception )
            {
                throw ;
            }
        }

    }
}
