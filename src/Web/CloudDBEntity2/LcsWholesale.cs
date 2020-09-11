using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsWholesale
    {
        public uint ActId { get; set; }
        public uint GoodsId { get; set; }
        public string GoodsName { get; set; }
        public string RankIds { get; set; }
        public string Prices { get; set; }
        public byte Enabled { get; set; }
    }
}
