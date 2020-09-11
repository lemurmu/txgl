using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsVote
    {
        public ushort VoteId { get; set; }
        public string VoteName { get; set; }
        public uint StartTime { get; set; }
        public uint EndTime { get; set; }
        public byte CanMulti { get; set; }
        public uint VoteCount { get; set; }
    }
}
