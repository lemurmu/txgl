using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsUserBonus
    {
        public uint BonusId { get; set; }
        public byte BonusTypeId { get; set; }
        public ulong BonusSn { get; set; }
        public uint UserId { get; set; }
        public uint UsedTime { get; set; }
        public uint OrderId { get; set; }
        public byte Emailed { get; set; }
    }
}
