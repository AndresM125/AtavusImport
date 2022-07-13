using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class OrganizationUser
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public long? OrganizationId { get; set; }
        public DateTime? RetiredAt { get; set; }
        public DateTime? ActivatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual User? User { get; set; }
    }
}
