using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsMailTemplates
    {
        public byte TemplateId { get; set; }
        public string TemplateCode { get; set; }
        public byte IsHtml { get; set; }
        public string TemplateSubject { get; set; }
        public string TemplateContent { get; set; }
        public uint LastModify { get; set; }
        public uint LastSend { get; set; }
        public string Type { get; set; }
    }
}
