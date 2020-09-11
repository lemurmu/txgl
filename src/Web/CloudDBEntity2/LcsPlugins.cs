using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsPlugins
    {
        public string Code { get; set; }
        public string Version { get; set; }
        public string Library { get; set; }
        public byte Assign { get; set; }
        public uint InstallDate { get; set; }
    }
}
