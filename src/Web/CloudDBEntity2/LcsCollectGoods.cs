using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsCollectGoods
    {
        public uint RecId { get; set; }
        public uint UserId { get; set; }
        public uint GoodsId { get; set; }
        public uint AddTime { get; set; }
        public bool IsAttention { get; set; }
    }
}
