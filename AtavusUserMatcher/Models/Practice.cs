using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class Practice
    {
        public Practice()
        {
            PracticeDrills = new HashSet<PracticeDrill>();
        }

        public long Id { get; set; }
        public string? TimePerDrill { get; set; }
        public long? PracticeWeekId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? Relevance { get; set; }

        public virtual PracticeWeek? PracticeWeek { get; set; }
        public virtual ICollection<PracticeDrill> PracticeDrills { get; set; }
    }
}
