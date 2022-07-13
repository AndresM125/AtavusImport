using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class ProductUser
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public string? Status { get; set; }
        public string? StripeId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long? ProductId { get; set; }
        public string? StripeProductSku { get; set; }
    }
}
