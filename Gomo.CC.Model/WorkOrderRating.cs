using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class WorkOrderRating
    {
        public int Id { get; set; }
        public int? SwoId { get; set; }
        public double? Rating1 { get; set; }
        public double? Rating2 { get; set; }
        public double? Rating3 { get; set; }
        public double? Rating4 { get; set; }
        public double? OverallRating { get; set; }
        public DateTime? AddDate { get; set; }

        public ShopWorkOrder Swo { get; set; }
    }
}
