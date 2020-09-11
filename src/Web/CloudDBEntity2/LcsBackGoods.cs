﻿using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsBackGoods
    {
        public uint RecId { get; set; }
        public uint? BackId { get; set; }
        public uint GoodsId { get; set; }
        public uint ProductId { get; set; }
        public string ProductSn { get; set; }
        public string GoodsName { get; set; }
        public string BrandName { get; set; }
        public string GoodsSn { get; set; }
        public byte? IsReal { get; set; }
        public ushort? SendNumber { get; set; }
        public string GoodsAttr { get; set; }
    }
}