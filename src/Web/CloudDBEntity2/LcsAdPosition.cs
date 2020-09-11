using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsAdPosition
    {
        public byte PositionId { get; set; }
        public string PositionName { get; set; }
        public ushort AdWidth { get; set; }
        public ushort AdHeight { get; set; }
        public string PositionDesc { get; set; }
        public string PositionStyle { get; set; }
    }
}
