using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class GoodsAnswer
    {
        public int Id { get; set; }
        public int? GqId { get; set; }
        public string Content { get; set; }
        public DateTime? AddDate { get; set; }

        public GoodsQuestion Gq { get; set; }
    }
}
