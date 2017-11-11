using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class RepairShopInventory
    {
        public int Id { get; set; }
        public int? RepairShopInfoId { get; set; }
        public int? ShopPartsTypeId { get; set; }
        public string PartNo { get; set; }
        public string PartName { get; set; }
        public int? Vendor { get; set; }
        public DateTime? PoDate { get; set; }
        public int? PoQty { get; set; }
        public int? StockQty { get; set; }
        public int? SafeQty { get; set; }
        public int? PackageUnit { get; set; }
        public double? Cost { get; set; }
        public double? Sell { get; set; }
        public double? ResellerPrice { get; set; }
        public double? MarKetPrice { get; set; }
        public int? PoNo { get; set; }
        public DateTime? ExpireDate { get; set; }
        public bool? Paid { get; set; }
        public int? DelFlag { get; set; }
        public bool? PartsTypeIsDefault { get; set; }

        public ShopAccountPayable PoNoNavigation { get; set; }
    }
}
