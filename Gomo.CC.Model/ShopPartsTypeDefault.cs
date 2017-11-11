using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class ShopPartsTypeDefault
    {
        public int Id { get; set; }
        public int? ShopPartsTypeCategoryId { get; set; }
        public string PartsNo { get; set; }
        public string PartsName { get; set; }
        public string PartsNameEn { get; set; }
        public int? Expireterm { get; set; }
        public int? Mileage { get; set; }

        public ShopPartsTypeCategory ShopPartsTypeCategory { get; set; }
    }
}
