using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class CommonInformationListItem
    {
        public long Id { get; set; }
        public long? CommonInformationListId { get; set; }
        public string? Content { get; set; }
        public int? Relevance { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual CommonInformationList? CommonInformationList { get; set; }
    }
}
