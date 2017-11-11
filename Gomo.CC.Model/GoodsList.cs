using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class GoodsList
    {
        public GoodsList()
        {
            GoodsOrderRating = new HashSet<GoodsOrderRating>();
            GoodsPhoto = new HashSet<GoodsPhoto>();
            GoodsQuestion = new HashSet<GoodsQuestion>();
        }

        public int Id { get; set; }
        public int? RsaId { get; set; }
        public int? RsiId { get; set; }
        public DateTime? GoolsName { get; set; }
        public double? Sell { get; set; }
        public int? Qty { get; set; }
        public double? Total { get; set; }
        public string GoodsDescription { get; set; }
        public string DealInformation { get; set; }
        public DateTime? AddDate { get; set; }
        public int? Status { get; set; }
        public int? ViewCount { get; set; }
        public string GoodsName { get; set; }
        public int? DelFlag { get; set; }

        public ICollection<GoodsOrderRating> GoodsOrderRating { get; set; }
        public ICollection<GoodsPhoto> GoodsPhoto { get; set; }
        public ICollection<GoodsQuestion> GoodsQuestion { get; set; }
    }
}
