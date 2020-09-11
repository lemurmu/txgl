using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsPayLog
    {
        public uint LogId { get; set; }
        public uint OrderId { get; set; }
        public decimal OrderAmount { get; set; }
        public byte OrderType { get; set; }
        public byte IsPaid { get; set; }
    }
}
