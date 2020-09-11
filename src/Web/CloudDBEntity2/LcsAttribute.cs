using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsAttribute
    {
        public ushort AttrId { get; set; }
        public ushort CatId { get; set; }
        public string AttrName { get; set; }
        public byte AttrInputType { get; set; }
        public byte AttrType { get; set; }
        public string AttrValues { get; set; }
        public byte AttrIndex { get; set; }
        public byte SortOrder { get; set; }
        public byte IsLinked { get; set; }
        public byte AttrGroup { get; set; }
    }
}
