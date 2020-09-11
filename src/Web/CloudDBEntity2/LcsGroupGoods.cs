using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsGroupGoods
    {
        public uint ParentId { get; set; }
        public uint GoodsId { get; set; }
        public decimal GoodsPrice { get; set; }
        public byte AdminId { get; set; }
    }
}
