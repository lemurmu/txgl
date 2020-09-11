using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsExchangeGoods
    {
        public uint GoodsId { get; set; }
        public uint ExchangeIntegral { get; set; }
        public byte IsExchange { get; set; }
        public byte IsHot { get; set; }
    }
}
