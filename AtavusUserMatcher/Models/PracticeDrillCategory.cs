using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class PracticeDrillCategory
    {
        public PracticeDrillCategory()
        {
            PracticeDrills = new HashSet<PracticeDrill>();
        }

        public long Id { get; set; }
        public string? Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? Relevance { get; set; }

        public virtual ICollection<PracticeDrill> PracticeDrills { get; set; }
    }
}
