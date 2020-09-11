using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsKeywords
    {
        public DateTime Date { get; set; }
        public string Searchengine { get; set; }
        public string Keyword { get; set; }
        public uint Count { get; set; }
    }
}
