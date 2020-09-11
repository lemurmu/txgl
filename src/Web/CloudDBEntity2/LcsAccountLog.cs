using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsAccountLog
    {
        public uint LogId { get; set; }
        public uint UserId { get; set; }
        public decimal UserMoney { get; set; }
        public decimal FrozenMoney { get; set; }
        public int RankPoints { get; set; }
        public int PayPoints { get; set; }
        public uint ChangeTime { get; set; }
        public string ChangeDesc { get; set; }
        public byte ChangeType { get; set; }
    }
}
