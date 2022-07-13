using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class Import
    {
        public Import()
        {
            ImportedUsers = new HashSet<ImportedUser>();
            Organizations = new HashSet<Organization>();
            UserImportFails = new HashSet<UserImportFail>();
        }

        public long Id { get; set; }
        public string? State { get; set; }
        public string? Filename { get; set; }
        public DateTime? ImportedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? ImportType { get; set; }
        public int? ImportedUsersCount { get; set; }
        public int? UserImportFailsCount { get; set; }

        public virtual ICollection<ImportedUser> ImportedUsers { get; set; }
        public virtual ICollection<Organization> Organizations { get; set; }
        public virtual ICollection<UserImportFail> UserImportFails { get; set; }
    }
}
