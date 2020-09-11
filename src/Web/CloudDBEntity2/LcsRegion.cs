using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsRegion
    {
        public ushort RegionId { get; set; }
        public ushort ParentId { get; set; }
        public string RegionName { get; set; }
        public bool? RegionType { get; set; }
        public ushort AgencyId { get; set; }
    }
}
