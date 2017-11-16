using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class RepairShopLaborDefault
    {
        public int Id { get; set; }
        public int? RepairShopLaborCategoryId { get; set; }
        public string LaborTypeNo { get; set; }
        public string ServiceItems { get; set; }
        public string ServiceItemsEn { get; set; }
        public int? Qty { get; set; }
        public double? Sell { get; set; }
        public double? Cost { get; set; }
        public double? WorkTime { get; set; }

        public RepairShopLaborCategory RepairShopLaborCategory { get; set; }
    }
}
