using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsGoodsType
    {
        public ushort CatId { get; set; }
        public string CatName { get; set; }
        public byte Enabled { get; set; }
        public string AttrGroup { get; set; }
    }
}
