using System;
using System.Collections.Generic;

namespace CloudDBEntity2
{
    public partial class LcsCategory
    {
        public ushort CatId { get; set; }
        public string CatName { get; set; }
        public string Keywords { get; set; }
        public string CatDesc { get; set; }
        public ushort ParentId { get; set; }
        public byte SortOrder { get; set; }
        public string TemplateFile { get; set; }
        public string MeasureUnit { get; set; }
        public bool ShowInNav { get; set; }
        public string Style { get; set; }
        public byte IsShow { get; set; }
        public sbyte Grade { get; set; }
        public string FilterAttr { get; set; }
    }
}
