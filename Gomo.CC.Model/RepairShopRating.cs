using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class RepairShopRating
    {
        public int Id { get; set; }
        public int? RepairShopInfoId { get; set; }
        public double? RatingItem1 { get; set; }
        public double? RatingItem2 { get; set; }
        public double? RatingItem3 { get; set; }
        public double? RatingItem4 { get; set; }
        public double? RatingItem5 { get; set; }
        public double? OverallRating { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
