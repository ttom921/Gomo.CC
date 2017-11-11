using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class RepairShopSupplier
    {
        public RepairShopSupplier()
        {
            ShopAccountPayable = new HashSet<ShopAccountPayable>();
        }

        public int Id { get; set; }
        public int? RepairShopInfoId { get; set; }
        public int? ShopPartsTypeId { get; set; }
        public string SupplierNo { get; set; }
        public string SupplierName { get; set; }
        public string Contact { get; set; }
        public string VatNumber { get; set; }
        public string Telephone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Email { get; set; }
        public int? Paymentterm { get; set; }
        public int? DelFlag { get; set; }

        public ICollection<ShopAccountPayable> ShopAccountPayable { get; set; }
    }
}
