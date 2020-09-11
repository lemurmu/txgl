using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsUserRank
    {
        public byte RankId { get; set; }
        public string RankName { get; set; }
        public uint MinPoints { get; set; }
        public uint MaxPoints { get; set; }
        public byte Discount { get; set; }
        public byte ShowPrice { get; set; }
        public byte SpecialRank { get; set; }
    }
}
