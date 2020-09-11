using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsLinkGoods
    {
        public uint GoodsId { get; set; }
        public uint LinkGoodsId { get; set; }
        public byte IsDouble { get; set; }
        public byte AdminId { get; set; }
    }
}
