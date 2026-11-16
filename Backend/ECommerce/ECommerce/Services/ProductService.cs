using AutoMapper;
using Ecommerce.Core.DTOs.Products;
using Ecommerce.Core.Entities;
using Ecommerce.Core.Interfaces;
using Ecommerce.Core.Services;

namespace ECommerce.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(
            IProductRepository productRepository,
            IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductResponseDto>> GetAllProducts()
        {
            var products = await _productRepository.GetAllProducts();

            return _mapper.Map<IEnumerable<ProductResponseDto>>(products);
        }

        public async Task<ProductResponseDto?> GetProductById(int productId)
        {
            var product = await _productRepository.GetProductById(productId);

            if (product == null)
                return null;

            return _mapper.Map<ProductResponseDto>(product);
        }

        public async Task<ProductResponseDto> AddProduct(CreateProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);

            var createdProduct = await _productRepository.AddProduct(product);

            return _mapper.Map<ProductResponseDto>(createdProduct);
        }

        public async Task<ProductResponseDto?> UpdateProduct(
            int productId,
            UpdateProductDto productDto)
        {
            var existingProduct =
                await _productRepository.GetProductById(productId);

            if (existingProduct == null)
                return null;

            // Map incoming DTO onto the existing entity
            _mapper.Map(productDto, existingProduct);

            var updatedProduct =
                await _productRepository.UpdateProduct(existingProduct);

            return _mapper.Map<ProductResponseDto>(updatedProduct);
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            var existingProduct =
                await _productRepository.GetProductById(productId);

            if (existingProduct == null)
                return false;

            await _productRepository.DeleteProduct(existingProduct);

            return true;
        }
    }
}
