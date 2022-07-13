using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class Plan
    {
        public Plan()
        {
            Organizations = new HashSet<Organization>();
            PlanPrices = new HashSet<PlanPrice>();
            Subscriptions = new HashSet<Subscription>();
        }

        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Tag { get; set; }
        public int? SortNumber { get; set; }
        public string StripeId { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Permissions { get; set; }

        public virtual ICollection<Organization> Organizations { get; set; }
        public virtual ICollection<PlanPrice> PlanPrices { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
