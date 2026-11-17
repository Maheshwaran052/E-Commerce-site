using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Core.DTOs
{
    public class CategoryWithProductsDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public List<ProductWithReviewsDto> Products { get; set; } = new List<ProductWithReviewsDto>();
    }
}
