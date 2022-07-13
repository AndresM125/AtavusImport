using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class StripeEvent
    {
        public long Id { get; set; }
        public string? Event { get; set; }
        public string? StripeId { get; set; }
        public string? Data { get; set; }
        public string? Request { get; set; }
        public string? ApiVersion { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
