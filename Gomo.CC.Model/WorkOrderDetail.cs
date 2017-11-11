using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class WorkOrderDetail
    {
        public int Id { get; set; }
        public int? SwoId { get; set; }
        public int? Type { get; set; }
        public int? GoodsId { get; set; }
        public int? WodId { get; set; }
        public int? Code { get; set; }
        public string Description { get; set; }
        public int? SsaId { get; set; }
        public string Sell { get; set; }
        public string Qty { get; set; }
        public string Disc { get; set; }
        public string Tax { get; set; }
        public string Total { get; set; }
        public int? SpmId { get; set; }

        public ShopWorkOrder Swo { get; set; }
    }
}
