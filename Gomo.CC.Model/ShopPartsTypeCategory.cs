using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class ShopPartsTypeCategory
    {
        public ShopPartsTypeCategory()
        {
            ShopPartsTypeDefault = new HashSet<ShopPartsTypeDefault>();
        }

        public int Id { get; set; }
        public string PartsType { get; set; }

        public ICollection<ShopPartsTypeDefault> ShopPartsTypeDefault { get; set; }
    }
}
