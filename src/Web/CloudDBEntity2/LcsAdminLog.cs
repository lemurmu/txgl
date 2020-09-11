using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsAdminLog
    {
        public uint LogId { get; set; }
        public uint LogTime { get; set; }
        public byte UserId { get; set; }
        public string LogInfo { get; set; }
        public string IpAddress { get; set; }
    }
}
