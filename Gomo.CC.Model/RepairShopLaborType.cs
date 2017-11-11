using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class RepairShopLaborType
    {
        public int Id { get; set; }
        public int? RepairShopInfoId { get; set; }
        public int? RepairShopLaborCategoryId { get; set; }
        public string Code { get; set; }
        public string ServiceItems { get; set; }
        public int? DelFlag { get; set; }
    }
}
