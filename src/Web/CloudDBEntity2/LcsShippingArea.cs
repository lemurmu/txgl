using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsShippingArea
    {
        public ushort ShippingAreaId { get; set; }
        public string ShippingAreaName { get; set; }
        public byte ShippingId { get; set; }
        public string Configure { get; set; }
    }
}
