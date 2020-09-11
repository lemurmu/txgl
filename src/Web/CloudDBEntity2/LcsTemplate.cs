using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsTemplate
    {
        public string Filename { get; set; }
        public string Region { get; set; }
        public string Library { get; set; }
        public byte SortOrder { get; set; }
        public ushort Id { get; set; }
        public byte Number { get; set; }
        public byte Type { get; set; }
        public string Theme { get; set; }
        public string Remarks { get; set; }
    }
}
