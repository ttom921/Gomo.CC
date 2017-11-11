using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class ReportPart
    {
        public int Id { get; set; }
        public int? SwoId { get; set; }
        public int? Type { get; set; }
        public int? PartTypeId { get; set; }
        public string PartTypeName { get; set; }
        public int? GoodsId { get; set; }
        public string PartName { get; set; }
        public int? Sell { get; set; }
        public int? Qty { get; set; }
        public int? Disc { get; set; }
        public int? Tax { get; set; }
        public int? Total { get; set; }
        public int? SpmId { get; set; }
        public int? Cost { get; set; }
        public int? Profit { get; set; }
    }
}
