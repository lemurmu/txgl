using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsAccountOtherLog
    {
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public string OrderSn { get; set; }
        public decimal Money { get; set; }
        public string PayType { get; set; }
        public string PayTime { get; set; }
        public string ChangeDesc { get; set; }
    }
}
