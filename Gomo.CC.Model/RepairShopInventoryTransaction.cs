using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class RepairShopInventoryTransaction
    {
        public long Id { get; set; }
        public int RepairShopInfoId { get; set; }
        public int RepairShopInventoryId { get; set; }
        public string Method { get; set; }
        public DateTime OpTime { get; set; }
        public decimal OpPrice { get; set; }
        public int OpQty { get; set; }
        public string RefFormType { get; set; }
        public int? RefFormId { get; set; }
        public string RefFormNote { get; set; }
    }
}
