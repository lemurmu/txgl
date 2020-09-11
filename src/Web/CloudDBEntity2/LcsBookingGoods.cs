using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsBookingGoods
    {
        public uint RecId { get; set; }
        public uint UserId { get; set; }
        public string Email { get; set; }
        public string LinkMan { get; set; }
        public string Tel { get; set; }
        public uint GoodsId { get; set; }
        public string GoodsDesc { get; set; }
        public ushort GoodsNumber { get; set; }
        public uint BookingTime { get; set; }
        public byte IsDispose { get; set; }
        public string DisposeUser { get; set; }
        public uint DisposeTime { get; set; }
        public string DisposeNote { get; set; }
    }
}
