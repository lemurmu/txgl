using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsVoteLog
    {
        public uint LogId { get; set; }
        public ushort VoteId { get; set; }
        public string IpAddress { get; set; }
        public uint VoteTime { get; set; }
    }
}
