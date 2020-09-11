using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsOrderGoods
    {
        public uint RecId { get; set; }
        public uint OrderId { get; set; }
        public uint GoodsId { get; set; }
        public string GoodsName { get; set; }
        public string GoodsSn { get; set; }
        public uint ProductId { get; set; }
        public ushort GoodsNumber { get; set; }
        public decimal MarketPrice { get; set; }
        public decimal GoodsPrice { get; set; }
        public decimal DiscountFee { get; set; }
        public string GoodsAttr { get; set; }
        public ushort SendNumber { get; set; }
        public byte IsReal { get; set; }
        public string ExtensionCode { get; set; }
        public uint ParentId { get; set; }
        public ushort IsGift { get; set; }
        public string GoodsAttrId { get; set; }
    }
}
