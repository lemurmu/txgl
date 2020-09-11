using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsCert
    {
        public uint Id { get; set; }
        public sbyte ConfigId { get; set; }
        public byte[] File { get; set; }
    }
}
