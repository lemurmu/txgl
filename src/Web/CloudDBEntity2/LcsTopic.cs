using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsTopic
    {
        public uint TopicId { get; set; }
        public string Title { get; set; }
        public string Intro { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public string Data { get; set; }
        public string Template { get; set; }
        public string Css { get; set; }
        public string TopicImg { get; set; }
        public string TitlePic { get; set; }
        public string BaseStyle { get; set; }
        public string Htmls { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }
    }
}
