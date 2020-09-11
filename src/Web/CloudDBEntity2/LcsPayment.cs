using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsPayment
    {
        public byte PayId { get; set; }
        public string PayCode { get; set; }
        public string PayName { get; set; }
        public string PayFee { get; set; }
        public string PayDesc { get; set; }
        public byte PayOrder { get; set; }
        public string PayConfig { get; set; }
        public byte Enabled { get; set; }
        public byte IsCod { get; set; }
        public byte IsOnline { get; set; }
    }
}
