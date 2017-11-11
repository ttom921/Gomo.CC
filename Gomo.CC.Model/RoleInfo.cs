using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class RoleInfo
    {
        public int Id { get; set; }
        public string RoleAuthorize { get; set; }
        public string RoleName { get; set; }
        public DateTime SubTime { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int DelFlag { get; set; }
    }
}
