using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class StudentUnitProgressHistory
    {
        public long Id { get; set; }
        public long? StudentUnitProgressId { get; set; }
        public string? State { get; set; }
        public DateTime? EventAt { get; set; }
        public string? Timezone { get; set; }
        public int? Attempts { get; set; }
        public int? Seed { get; set; }
        public decimal? CalculatedGrade { get; set; }
        public string? EventData { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual StudentUnitProgress? StudentUnitProgress { get; set; }
    }
}
