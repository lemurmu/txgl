using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsSearchHistory
    {
        public uint Id { get; set; }
        public string Keyword { get; set; }
        public int Count { get; set; }
        public string Type { get; set; }
        public int StoreId { get; set; }
        public int Updated { get; set; }
    }
}
