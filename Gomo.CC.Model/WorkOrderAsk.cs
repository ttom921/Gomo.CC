using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class WorkOrderAsk
    {
        public int Id { get; set; }
        public int? SwoId { get; set; }
        public int? SwotId { get; set; }
        public int? SsaId { get; set; }
        public int? CaId { get; set; }
        public string Content { get; set; }
        public string ImgUrl { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
