using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsShipping
    {
        public byte ShippingId { get; set; }
        public string ShippingCode { get; set; }
        public string ShippingName { get; set; }
        public string ShippingDesc { get; set; }
        public string Insure { get; set; }
        public byte SupportCod { get; set; }
        public byte Enabled { get; set; }
        public string ShippingPrint { get; set; }
        public string PrintBg { get; set; }
        public string ConfigLable { get; set; }
        public bool? PrintModel { get; set; }
        public byte ShippingOrder { get; set; }
    }
}
