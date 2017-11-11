using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class BestAnswerVote
    {
        public int Id { get; set; }
        public int? TaqId { get; set; }
        public int? TarId { get; set; }
        public int? RsaId { get; set; }
        public int? SsaId { get; set; }
        public DateTime? AddDate { get; set; }
    }
}
