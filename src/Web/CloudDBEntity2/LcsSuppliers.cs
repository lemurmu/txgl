using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsSuppliers
    {
        public ushort SuppliersId { get; set; }
        public string SuppliersName { get; set; }
        public string SuppliersDesc { get; set; }
        public byte IsCheck { get; set; }
    }
}
