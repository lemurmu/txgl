using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsOrderInfo
    {
        public uint OrderId { get; set; }
        public string OrderSn { get; set; }
        public uint UserId { get; set; }
        public byte OrderStatus { get; set; }
        public byte ShippingStatus { get; set; }
        public byte PayStatus { get; set; }
        public string Consignee { get; set; }
        public ushort Country { get; set; }
        public ushort Province { get; set; }
        public ushort City { get; set; }
        public ushort District { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string BestTime { get; set; }
        public string SignBuilding { get; set; }
        public string Postscript { get; set; }
        public sbyte ShippingId { get; set; }
        public string ShippingName { get; set; }
        public sbyte PayId { get; set; }
        public string PayName { get; set; }
        public string HowOos { get; set; }
        public string HowSurplus { get; set; }
        public string PackName { get; set; }
        public string CardName { get; set; }
        public string CardMessage { get; set; }
        public string InvPayee { get; set; }
        public string InvContent { get; set; }
        public decimal GoodsAmount { get; set; }
        public decimal ShippingFee { get; set; }
        public decimal InsureFee { get; set; }
        public decimal PayFee { get; set; }
        public decimal PackFee { get; set; }
        public decimal CardFee { get; set; }
        public decimal GoodsDiscountFee { get; set; }
        public decimal MoneyPaid { get; set; }
        public decimal Surplus { get; set; }
        public uint Integral { get; set; }
        public decimal IntegralMoney { get; set; }
        public decimal Bonus { get; set; }
        public decimal OrderAmount { get; set; }
        public short FromAd { get; set; }
        public string Referer { get; set; }
        public uint AddTime { get; set; }
        public uint ConfirmTime { get; set; }
        public uint PayTime { get; set; }
        public uint ShippingTime { get; set; }
        public byte PackId { get; set; }
        public byte CardId { get; set; }
        public uint BonusId { get; set; }
        public string InvoiceNo { get; set; }
        public string ExtensionCode { get; set; }
        public uint ExtensionId { get; set; }
        public string ToBuyer { get; set; }
        public string PayNote { get; set; }
        public ushort AgencyId { get; set; }
        public string InvType { get; set; }
        public decimal Tax { get; set; }
        public bool IsSeparate { get; set; }
        public uint ParentId { get; set; }
        public decimal Discount { get; set; }
        public string CallbackStatus { get; set; }
        public uint Lastmodify { get; set; }
    }
}
