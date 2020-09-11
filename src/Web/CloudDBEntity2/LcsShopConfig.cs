using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsShopConfig
    {
        public ushort Id { get; set; }
        public ushort ParentId { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public string StoreRange { get; set; }
        public string StoreDir { get; set; }
        public string Value { get; set; }
        public byte SortOrder { get; set; }
    }
}
