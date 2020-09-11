using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsUserAccount
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public string AdminUser { get; set; }
        public decimal Amount { get; set; }
        public int AddTime { get; set; }
        public int PaidTime { get; set; }
        public string AdminNote { get; set; }
        public string UserNote { get; set; }
        public bool ProcessType { get; set; }
        public string Payment { get; set; }
        public bool IsPaid { get; set; }
    }
}
