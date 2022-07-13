using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class ImportedUser
    {
        public long Id { get; set; }
        public bool? Certified { get; set; }
        public DateTime? RegisteredAt { get; set; }
        public long? ImportId { get; set; }
        public long? UserId { get; set; }
        public string? ImportFields { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? ImportAction { get; set; }
        public string? MemberCode { get; set; }
        public long? OrganizationId { get; set; }
        public string? FirstName { get; set; }
        public string? InitialMiddleName { get; set; }
        public string? LastName { get; set; }
        public string? ProgramName { get; set; }
        public string? Street { get; set; }
        public string? Street2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? AtavusGuid { get; set; }
        public string? Metadata { get; set; }

        public virtual Import? Import { get; set; }
        public virtual User? User { get; set; }
    }
}
