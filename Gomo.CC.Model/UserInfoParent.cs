using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class UserInfoParent
    {
        public int UserInfoId { get; set; }
        public int ParentId { get; set; }
        public int DelFlag { get; set; }
    }
}
