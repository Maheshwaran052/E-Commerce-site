using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ecommerce.Core.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        
        public string Name { get; set; } = string.Empty;
    }
}
