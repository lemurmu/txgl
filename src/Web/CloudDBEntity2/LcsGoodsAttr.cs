using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsGoodsAttr
    {
        public uint GoodsAttrId { get; set; }
        public uint GoodsId { get; set; }
        public ushort AttrId { get; set; }
        public string AttrValue { get; set; }
        public string AttrPrice { get; set; }
    }
}
