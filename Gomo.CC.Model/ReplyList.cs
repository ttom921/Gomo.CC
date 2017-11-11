using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class ReplyList
    {
        public int Id { get; set; }
        public int? QlId { get; set; }
        public int? SmaId { get; set; }
        public string Content { get; set; }
        public DateTime? AddDate { get; set; }

        public QuestionList Ql { get; set; }
    }
}
