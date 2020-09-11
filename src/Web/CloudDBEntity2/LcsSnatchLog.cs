using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsSnatchLog
    {
        public uint LogId { get; set; }
        public byte SnatchId { get; set; }
        public uint UserId { get; set; }
        public decimal BidPrice { get; set; }
        public uint BidTime { get; set; }
    }
}
