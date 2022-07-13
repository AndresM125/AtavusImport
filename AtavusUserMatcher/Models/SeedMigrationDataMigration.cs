using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class SeedMigrationDataMigration
    {
        public int Id { get; set; }
        public string? Version { get; set; }
        public int? Runtime { get; set; }
        public DateTime? MigratedOn { get; set; }
    }
}
