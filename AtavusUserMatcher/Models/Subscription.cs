using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class Subscription
    {
        public Subscription()
        {
            SubscriptionLogs = new HashSet<SubscriptionLog>();
        }

        public long Id { get; set; }
        public long? UserId { get; set; }
        public string? Status { get; set; }
        public DateTime? StartAt { get; set; }
        public DateTime? RenovationAt { get; set; }
        public DateTime? LastBillingAt { get; set; }
        public string? StripeId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long? PlanId { get; set; }
        public string? StripePlanId { get; set; }
        public bool? CancelAtPeriodEnd { get; set; }
        public DateTime? CancelAt { get; set; }
        public string? PendingAction { get; set; }

        public virtual Plan? Plan { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<SubscriptionLog> SubscriptionLogs { get; set; }
    }
}
