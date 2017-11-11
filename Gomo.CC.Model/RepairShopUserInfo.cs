using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class RepairShopUserInfo
    {
        public int Id { get; set; }
        public int? UserInfoId { get; set; }
        public int? RepairShopInfoId { get; set; }
    }
}
