using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsVoteOption
    {
        public ushort OptionId { get; set; }
        public ushort VoteId { get; set; }
        public string OptionName { get; set; }
        public uint OptionCount { get; set; }
        public byte OptionOrder { get; set; }
    }
}
