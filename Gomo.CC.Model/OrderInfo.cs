using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class OrderInfo
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int UserInfoId { get; set; }
    }
}
