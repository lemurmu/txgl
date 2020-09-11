using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsArticleCat
    {
        public short CatId { get; set; }
        public string CatName { get; set; }
        public byte CatType { get; set; }
        public string Keywords { get; set; }
        public string CatDesc { get; set; }
        public byte SortOrder { get; set; }
        public byte ShowInNav { get; set; }
        public ushort ParentId { get; set; }
    }
}
