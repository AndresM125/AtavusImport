using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductSkus = new HashSet<ProductSku>();
        }

        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Caption { get; set; }
        public string? Description { get; set; }
        public int SortNumber { get; set; }
        public string StripeId { get; set; } = null!;
        public string? Category { get; set; }
        public bool? InCoachKit { get; set; }
        public string? Permissions { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? ProductableType { get; set; }
        public long? ProductableId { get; set; }

        public virtual ICollection<ProductSku> ProductSkus { get; set; }
    }
}
