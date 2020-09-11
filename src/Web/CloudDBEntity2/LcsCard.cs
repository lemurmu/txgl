using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsCard
    {
        public byte CardId { get; set; }
        public string CardName { get; set; }
        public string CardImg { get; set; }
        public decimal CardFee { get; set; }
        public decimal FreeMoney { get; set; }
        public string CardDesc { get; set; }
    }
}
