using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class PlanBuilder
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public int AtavusWork { get; set; }
        public int? AtavusTime { get; set; }
        public int PracticesQuantity { get; set; }
        public int PracticesMinutes { get; set; }
        public string PlanSlug { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual User? User { get; set; }
    }
}
