using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsFavourableActivity
    {
        public ushort ActId { get; set; }
        public string ActName { get; set; }
        public uint StartTime { get; set; }
        public uint EndTime { get; set; }
        public string UserRank { get; set; }
        public byte ActRange { get; set; }
        public string ActRangeExt { get; set; }
        public decimal MinAmount { get; set; }
        public decimal MaxAmount { get; set; }
        public byte ActType { get; set; }
        public decimal ActTypeExt { get; set; }
        public string Gift { get; set; }
        public byte SortOrder { get; set; }
    }
}
