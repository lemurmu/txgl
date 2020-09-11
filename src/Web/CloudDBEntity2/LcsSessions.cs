using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsSessions
    {
        public string Sesskey { get; set; }
        public uint Expiry { get; set; }
        public uint Userid { get; set; }
        public uint Adminid { get; set; }
        public string Ip { get; set; }
        public string UserName { get; set; }
        public sbyte UserRank { get; set; }
        public decimal Discount { get; set; }
        public string Email { get; set; }
        public string Data { get; set; }
    }
}
