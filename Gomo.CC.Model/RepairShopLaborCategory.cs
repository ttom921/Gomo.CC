using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class RepairShopLaborCategory
    {
        public RepairShopLaborCategory()
        {
            RepairShopLaborDefault = new HashSet<RepairShopLaborDefault>();
        }

        public int Id { get; set; }
        public string LaborType { get; set; }

        public ICollection<RepairShopLaborDefault> RepairShopLaborDefault { get; set; }
    }
}
