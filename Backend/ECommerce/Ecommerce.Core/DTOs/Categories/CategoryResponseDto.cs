using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Core.DTOs.Categories
{
    public class CategoryResponseDto
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
