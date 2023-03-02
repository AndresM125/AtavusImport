using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class Unit
    {
        public Unit()
        {
            StudentUnitProgresses = new HashSet<StudentUnitProgress>();
        }

        public long Id { get; set; }
        public long? ChapterId { get; set; }
        public int? ComponentId { get; set; }
        public string? ComponentType { get; set; }
        public int? MinutesEstimate { get; set; }
        public bool? IsActive { get; set; }
        public int? SortNumber { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Code { get; set; }

        public virtual Chapter? Chapter { get; set; }
        public virtual ICollection<StudentUnitProgress> StudentUnitProgresses { get; set; }
    }
}
