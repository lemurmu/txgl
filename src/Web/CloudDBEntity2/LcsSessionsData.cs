using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsSessionsData
    {
        public string Sesskey { get; set; }
        public uint Expiry { get; set; }
        public string Data { get; set; }
    }
}
