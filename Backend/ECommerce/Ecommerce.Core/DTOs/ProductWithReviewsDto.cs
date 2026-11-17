using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Core.DTOs
{
    public class ProductWithReviewsDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = String.Empty;
        public List<ProductReviewDto> Reviews { get; set; } = new List<ProductReviewDto>();
    }
}
