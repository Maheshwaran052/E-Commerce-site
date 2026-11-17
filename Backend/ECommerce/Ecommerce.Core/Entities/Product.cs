using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ecommerce.Core.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; } = string.Empty;

        [Range(1, 1000000)]
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; }

        public ICollection<ProductReview> Reviews { get; set; } = new List<ProductReview>();

        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
    }
}
