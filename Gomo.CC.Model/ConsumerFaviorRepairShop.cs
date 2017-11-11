using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class ConsumerFaviorRepairShop
    {
        public int Id { get; set; }
        public int UserInfoId { get; set; }
        public int RepairShopInfoId { get; set; }
        public bool? IsFavior { get; set; }
        public bool? IsMember { get; set; }
    }
}
