using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class CommonInformationListDefinition
    {
        public CommonInformationListDefinition()
        {
            CommonInformationLists = new HashSet<CommonInformationList>();
        }

        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Color { get; set; }
        public string? ListStyle { get; set; }
        public string? ListStyleImagePath { get; set; }
        public int? Relevance { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<CommonInformationList> CommonInformationLists { get; set; }
    }
}
