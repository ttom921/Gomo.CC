using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class RepairShopLabor
    {
        public int Id { get; set; }
        public int? RepairShopInfoId { get; set; }
        public int? LaborType { get; set; }
        public string ServiceItems { get; set; }
        public int Qty { get; set; }
        public double? Sell { get; set; }
        public double? Cost { get; set; }
        public double? WorkTime { get; set; }
        public int? DelFlag { get; set; }
        public bool? IsDefault { get; set; }
    }
}
