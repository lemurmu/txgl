using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsArticle
    {
        public uint ArticleId { get; set; }
        public short CatId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string AuthorEmail { get; set; }
        public string Keywords { get; set; }
        public byte ArticleType { get; set; }
        public byte IsOpen { get; set; }
        public uint AddTime { get; set; }
        public string FileUrl { get; set; }
        public byte OpenType { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
    }
}
