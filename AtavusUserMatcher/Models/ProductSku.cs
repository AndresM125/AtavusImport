using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class ProductSku
    {
        public long Id { get; set; }
        public long? ProductId { get; set; }
        public string? Currency { get; set; }
        public decimal? Price { get; set; }
        public string? Tag { get; set; }
        public string StripeId { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Product? Product { get; set; }
    }
}
