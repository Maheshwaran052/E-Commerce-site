using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ecommerce.Core.Entities
{
    public class ProductReview
    {
        [Key]
        public int ReviewId { get; set; }
        public int ProductId { get; set; }
        public string ReviewerName { get; set; } = string.Empty;
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;

        [ForeignKey("ProductId")]
        public Product? Product { get; set; }
    }
}
