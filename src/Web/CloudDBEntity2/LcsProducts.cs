using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsProducts
    {
        public uint ProductId { get; set; }
        public uint GoodsId { get; set; }
        public string GoodsAttr { get; set; }
        public string ProductSn { get; set; }
        public uint? ProductNumber { get; set; }
    }
}
