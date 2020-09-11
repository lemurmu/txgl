using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsBonusType
    {
        public ushort TypeId { get; set; }
        public string TypeName { get; set; }
        public decimal TypeMoney { get; set; }
        public byte SendType { get; set; }
        public decimal MinAmount { get; set; }
        public decimal MaxAmount { get; set; }
        public int SendStartDate { get; set; }
        public int SendEndDate { get; set; }
        public int UseStartDate { get; set; }
        public int UseEndDate { get; set; }
        public decimal MinGoodsAmount { get; set; }
    }
}
