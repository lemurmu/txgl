using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsVersion
    {
        public uint Id { get; set; }
        public sbyte Platform { get; set; }
        public string Version { get; set; }
        public string Url { get; set; }
        public string Content { get; set; }
        public sbyte Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
