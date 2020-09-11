using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsBackOrder
    {
        public uint BackId { get; set; }
        public string DeliverySn { get; set; }
        public string OrderSn { get; set; }
        public uint OrderId { get; set; }
        public string InvoiceNo { get; set; }
        public uint? AddTime { get; set; }
        public byte? ShippingId { get; set; }
        public string ShippingName { get; set; }
        public uint? UserId { get; set; }
        public string ActionUser { get; set; }
        public string Consignee { get; set; }
        public string Address { get; set; }
        public ushort? Country { get; set; }
        public ushort? Province { get; set; }
        public ushort? City { get; set; }
        public ushort? District { get; set; }
        public string SignBuilding { get; set; }
        public string Email { get; set; }
        public string Zipcode { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string BestTime { get; set; }
        public string Postscript { get; set; }
        public string HowOos { get; set; }
        public decimal? InsureFee { get; set; }
        public decimal? ShippingFee { get; set; }
        public uint? UpdateTime { get; set; }
        public short? SuppliersId { get; set; }
        public byte Status { get; set; }
        public uint? ReturnTime { get; set; }
        public ushort? AgencyId { get; set; }
    }
}
