using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class UserImportFail
    {
        public long Id { get; set; }
        public string? Email { get; set; }
        public string? MemberCode { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? OrganizationCode { get; set; }
        public string? CertificationStatus { get; set; }
        public bool? Certified { get; set; }
        public decimal? CertificationScore { get; set; }
        public string? FailReason { get; set; }
        public long? ImportId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Metadata { get; set; }

        public virtual Import? Import { get; set; }
    }
}
