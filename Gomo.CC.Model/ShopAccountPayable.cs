using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class ShopAccountPayable
    {
        public ShopAccountPayable()
        {
            RepairShopInventory = new HashSet<RepairShopInventory>();
        }

        public int Id { get; set; }
        public int? RsaId { get; set; }
        public string Barcode { get; set; }
        public string PoNo { get; set; }
        public DateTime? PoDate { get; set; }
        public int? RssId { get; set; }
        public double? Balance { get; set; }

        public RepairShopAccount Rsa { get; set; }
        public RepairShopSupplier Rss { get; set; }
        public ICollection<RepairShopInventory> RepairShopInventory { get; set; }
    }
}
