using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsBrand
    {
        public ushort BrandId { get; set; }
        public string BrandName { get; set; }
        public string BrandLogo { get; set; }
        public string BrandDesc { get; set; }
        public string SiteUrl { get; set; }
        public byte SortOrder { get; set; }
        public byte IsShow { get; set; }
    }
}
