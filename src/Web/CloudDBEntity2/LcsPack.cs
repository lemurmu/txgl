using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsPack
    {
        public byte PackId { get; set; }
        public string PackName { get; set; }
        public string PackImg { get; set; }
        public decimal PackFee { get; set; }
        public ushort FreeMoney { get; set; }
        public string PackDesc { get; set; }
    }
}
