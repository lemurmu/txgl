using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsNav
    {
        public int Id { get; set; }
        public string Ctype { get; set; }
        public ushort? Cid { get; set; }
        public string Name { get; set; }
        public bool Ifshow { get; set; }
        public bool Vieworder { get; set; }
        public bool Opennew { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
    }
}
