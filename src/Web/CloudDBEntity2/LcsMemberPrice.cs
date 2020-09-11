using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsMemberPrice
    {
        public uint PriceId { get; set; }
        public uint GoodsId { get; set; }
        public sbyte UserRank { get; set; }
        public decimal UserPrice { get; set; }
    }
}
