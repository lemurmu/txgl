using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsAffiliateLog
    {
        public int LogId { get; set; }
        public int OrderId { get; set; }
        public int Time { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public decimal Money { get; set; }
        public int Point { get; set; }
        public bool SeparateType { get; set; }
    }
}
