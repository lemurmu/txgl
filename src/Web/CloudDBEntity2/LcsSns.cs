using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsSns
    {
        public int UserId { get; set; }
        public string OpenId { get; set; }
        public sbyte Vendor { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
