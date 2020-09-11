using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsPackageGoods
    {
        public uint PackageId { get; set; }
        public uint GoodsId { get; set; }
        public uint ProductId { get; set; }
        public ushort GoodsNumber { get; set; }
        public byte AdminId { get; set; }
    }
}
