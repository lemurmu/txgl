using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsGoodsActivity
    {
        public uint ActId { get; set; }
        public string ActName { get; set; }
        public string ActDesc { get; set; }
        public byte ActType { get; set; }
        public uint GoodsId { get; set; }
        public uint ProductId { get; set; }
        public string GoodsName { get; set; }
        public uint StartTime { get; set; }
        public uint EndTime { get; set; }
        public byte IsFinished { get; set; }
        public string ExtInfo { get; set; }
    }
}
