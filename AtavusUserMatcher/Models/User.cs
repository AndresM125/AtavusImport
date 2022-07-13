using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class User
    {
        public User()
        {
            Enrollments = new HashSet<Enrollment>();
            ImportedUsers = new HashSet<ImportedUser>();
            OrganizationUsers = new HashSet<OrganizationUser>();
            Subscriptions = new HashSet<Subscription>();
        }

        public long Id { get; set; }
        public string? Email { get; set; }
        public string EncryptedPassword { get; set; } = null!;
        public string? ResetPasswordToken { get; set; }
        public DateTime? ResetPasswordSentAt { get; set; }
        public DateTime? RememberCreatedAt { get; set; }
        public int SignInCount { get; set; }
        public DateTime? CurrentSignInAt { get; set; }
        public DateTime? LastSignInAt { get; set; }
        public string? CurrentSignInIp { get; set; }
        public string? LastSignInIp { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public DateTime? ActivatedAt { get; set; }
        public bool? Certified { get; set; }
        public string? MemberCode { get; set; }
        public string? OrganizationName { get; set; }
        public string? Street { get; set; }
        public string? Street2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? Zip { get; set; }
        public long? OrganizationId { get; set; }
        public string? AtavusGuid { get; set; }
        public string? ProgramName { get; set; }
        public bool? Active { get; set; }
        public string? StripeCustomerId { get; set; }
        public string? Metadata { get; set; }
        public long? RoleId { get; set; }
        public string? Permissions { get; set; }
        public bool? TestAccount { get; set; }
        public int? HubspotId { get; set; }

        public virtual Role? Role { get; set; }
        public virtual PlanBuilder? PlanBuilder { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<ImportedUser> ImportedUsers { get; set; }
        public virtual ICollection<OrganizationUser> OrganizationUsers { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
