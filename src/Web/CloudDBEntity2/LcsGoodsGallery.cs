using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsGoodsGallery
    {
        public uint ImgId { get; set; }
        public uint GoodsId { get; set; }
        public string ImgUrl { get; set; }
        public string ImgDesc { get; set; }
        public string ThumbUrl { get; set; }
        public string ImgOriginal { get; set; }
    }
}
