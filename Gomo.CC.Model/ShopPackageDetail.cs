using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class ShopPackageDetail
    {
        public int Id { get; set; }
        public int? ShopPackageMainId { get; set; }
        public int? GoodsType { get; set; }
        public int? GoodsId { get; set; }
        public double? Sell { get; set; }
        public double? Qty { get; set; }
        public double? Tax { get; set; }
        public double? Total { get; set; }

        public ShopPackageMain ShopPackageMain { get; set; }
    }
}
