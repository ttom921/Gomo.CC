using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class UserInfoRoleInfo
    {
        public int Id { get; set; }
        public int UserInfoId { get; set; }
        public int RoleInfoId { get; set; }
        public int? DelFlag { get; set; }
    }
}
