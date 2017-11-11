using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class ShopPartsType
    {
        public int Id { get; set; }
        public int? RepairShopInfoId { get; set; }
        public string Code { get; set; }
        public string PartsName { get; set; }
        public int? Expireterm { get; set; }
        public int? Mileage { get; set; }
        public int? DelFlag { get; set; }
        public int? ShopPartsTypeCategoryId { get; set; }
    }
}
