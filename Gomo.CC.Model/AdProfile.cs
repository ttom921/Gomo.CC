using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class AdProfile
    {
        public int Id { get; set; }
        public int? UserInfoId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? TimeTern { get; set; }
        public sbyte? Paid { get; set; }
        public int? DelFlag { get; set; }
    }
}
