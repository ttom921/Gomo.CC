using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class ShopPackageMain
    {
        public ShopPackageMain()
        {
            ShopPackageDetail = new HashSet<ShopPackageDetail>();
        }

        public int Id { get; set; }
        public int? RepairShopInfoId { get; set; }
        public string PackageName { get; set; }
        public string Description { get; set; }
        public double? Discount { get; set; }
        public double? Total { get; set; }
        public int? DelFlag { get; set; }

        public ICollection<ShopPackageDetail> ShopPackageDetail { get; set; }
    }
}
