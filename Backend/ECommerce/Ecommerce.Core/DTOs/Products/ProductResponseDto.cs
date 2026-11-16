using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Core.DTOs.Products
{
    public class ProductResponseDto
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; }
    }
}
