using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class PlanPrice
    {
        public long Id { get; set; }
        public long? PlanId { get; set; }
        public string? Nickname { get; set; }
        public string? Currency { get; set; }
        public decimal? Price { get; set; }
        public string? Periodicity { get; set; }
        public string StripeId { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Plan? Plan { get; set; }
    }
}
