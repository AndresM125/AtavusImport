using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class SubscriptionLog
    {
        public long Id { get; set; }
        public long? SubscriptionId { get; set; }
        public string? Action { get; set; }
        public string? Metadata { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Subscription? Subscription { get; set; }
    }
}
