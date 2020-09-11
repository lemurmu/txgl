using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsGoods
    {
        public uint GoodsId { get; set; }
        public ushort CatId { get; set; }
        public string GoodsSn { get; set; }
        public string GoodsName { get; set; }
        public string GoodsNameStyle { get; set; }
        public uint ClickCount { get; set; }
        public ushort BrandId { get; set; }
        public string ProviderName { get; set; }
        public uint GoodsNumber { get; set; }
        public decimal GoodsWeight { get; set; }
        public decimal MarketPrice { get; set; }
        public ushort VirtualSales { get; set; }
        public decimal ShopPrice { get; set; }
        public decimal PromotePrice { get; set; }
        public uint PromoteStartDate { get; set; }
        public uint PromoteEndDate { get; set; }
        public byte WarnNumber { get; set; }
        public string Keywords { get; set; }
        public string GoodsBrief { get; set; }
        public string GoodsDesc { get; set; }
        public string GoodsThumb { get; set; }
        public string GoodsImg { get; set; }
        public string OriginalImg { get; set; }
        public byte IsReal { get; set; }
        public string ExtensionCode { get; set; }
        public byte IsOnSale { get; set; }
        public byte IsAloneSale { get; set; }
        public byte IsShipping { get; set; }
        public uint Integral { get; set; }
        public uint AddTime { get; set; }
        public ushort SortOrder { get; set; }
        public byte IsDelete { get; set; }
        public byte IsBest { get; set; }
        public byte IsNew { get; set; }
        public byte IsHot { get; set; }
        public byte IsPromote { get; set; }
        public byte BonusTypeId { get; set; }
        public uint LastUpdate { get; set; }
        public ushort GoodsType { get; set; }
        public string SellerNote { get; set; }
        public int GiveIntegral { get; set; }
        public int RankIntegral { get; set; }
        public ushort? SuppliersId { get; set; }
        public byte? IsCheck { get; set; }
    }
}
