using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsFriendLink
    {
        public ushort LinkId { get; set; }
        public string LinkName { get; set; }
        public string LinkUrl { get; set; }
        public string LinkLogo { get; set; }
        public byte ShowOrder { get; set; }
    }
}
