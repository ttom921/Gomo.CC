using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class WorkOrderDetailHistory
    {
        public int Id { get; set; }
        public int? ShopWorkOrderHistoryId { get; set; }
        public int? Type { get; set; }
        public string PackageName { get; set; }
        public string Description { get; set; }
        public string Technician { get; set; }
        public string Sell { get; set; }
        public string Qty { get; set; }
        public string Disc { get; set; }
        public string Tax { get; set; }
        public string Total { get; set; }
    }
}
