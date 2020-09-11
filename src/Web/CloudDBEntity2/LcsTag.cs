using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsTag
    {
        public int TagId { get; set; }
        public uint UserId { get; set; }
        public uint GoodsId { get; set; }
        public string TagWords { get; set; }
    }
}
