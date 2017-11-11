using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class AdDetail
    {
        public int Id { get; set; }
        public int? AdProfileId { get; set; }
        public int? BannerType { get; set; }
        public DateTime? PlayStartDate { get; set; }
        public DateTime? PlayEndDate { get; set; }
        public string Url { get; set; }
        public bool? IsOnline { get; set; }
    }
}
