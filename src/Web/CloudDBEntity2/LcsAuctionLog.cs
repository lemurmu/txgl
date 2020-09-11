using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsAuctionLog
    {
        public uint LogId { get; set; }
        public uint ActId { get; set; }
        public uint BidUser { get; set; }
        public decimal BidPrice { get; set; }
        public uint BidTime { get; set; }
    }
}
