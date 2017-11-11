using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class GoodsOrderRating
    {
        public int Id { get; set; }
        public int? GlId { get; set; }
        public int? GoId { get; set; }
        public string Rating { get; set; }
        public DateTime? AddDate { get; set; }

        public GoodsList Gl { get; set; }
    }
}
