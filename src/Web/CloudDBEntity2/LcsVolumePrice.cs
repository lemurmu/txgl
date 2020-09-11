using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsVolumePrice
    {
        public byte PriceType { get; set; }
        public uint GoodsId { get; set; }
        public ushort VolumeNumber { get; set; }
        public decimal VolumePrice { get; set; }
    }
}
