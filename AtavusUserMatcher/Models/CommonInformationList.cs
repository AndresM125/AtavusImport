using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class CommonInformationList
    {
        public CommonInformationList()
        {
            CommonInformationListItems = new HashSet<CommonInformationListItem>();
        }

        public long Id { get; set; }
        public long? CommonInformationListDefinitionId { get; set; }
        public string? ResourceType { get; set; }
        public long? ResourceId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Name { get; set; }
        public int? Relevance { get; set; }

        public virtual CommonInformationListDefinition? CommonInformationListDefinition { get; set; }
        public virtual ICollection<CommonInformationListItem> CommonInformationListItems { get; set; }
    }
}
