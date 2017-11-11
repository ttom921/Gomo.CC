using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class TechAskQuestion
    {
        public int Id { get; set; }
        public int? TacId { get; set; }
        public int? RsaId { get; set; }
        public int? SsaId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? AddDate { get; set; }
        public int? ViewCount { get; set; }
        public DateTime? CalculateDate { get; set; }
        public int? Answer { get; set; }
        public int? AnswerCount { get; set; }
    }
}
