using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class RepairShopPhoto
    {
        public int Id { get; set; }
        public int? RepairShopInfoId { get; set; }
        public string ServiceImgUrl { get; set; }
        public bool? DeleteStatus { get; set; }
    }
}
