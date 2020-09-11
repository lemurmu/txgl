using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsOrderAction
    {
        public uint ActionId { get; set; }
        public uint OrderId { get; set; }
        public string ActionUser { get; set; }
        public byte OrderStatus { get; set; }
        public byte ShippingStatus { get; set; }
        public byte PayStatus { get; set; }
        public byte ActionPlace { get; set; }
        public string ActionNote { get; set; }
        public uint LogTime { get; set; }
    }
}
