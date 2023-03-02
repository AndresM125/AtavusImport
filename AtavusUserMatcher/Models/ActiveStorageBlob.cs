using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class ActiveStorageBlob
    {
        public long Id { get; set; }
        public string Key { get; set; } = null!;
        public string Filename { get; set; } = null!;
        public string? ContentType { get; set; }
        public string? Metadata { get; set; }
        public long ByteSize { get; set; }
        public string Checksum { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
}
