using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Core.DTOs
{
    public class ProductWithCategoryDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string CategoryName { get; set; } = string.Empty;

    }
}
