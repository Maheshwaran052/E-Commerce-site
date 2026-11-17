using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Core.DTOs
{
    public class ProductReviewDto
    {
        public int ReviewId { get; set; }
        public string ReviewerName { get; set; } = string.Empty;
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;
    }
}
