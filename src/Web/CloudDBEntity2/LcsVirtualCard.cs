using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsVirtualCard
    {
        public int CardId { get; set; }
        public uint GoodsId { get; set; }
        public string CardSn { get; set; }
        public string CardPassword { get; set; }
        public int AddDate { get; set; }
        public int EndDate { get; set; }
        public bool IsSaled { get; set; }
        public string OrderSn { get; set; }
        public string Crc32 { get; set; }
    }
}
