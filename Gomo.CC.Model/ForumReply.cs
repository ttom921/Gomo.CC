using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class ForumReply
    {
        public int Id { get; set; }
        public int? FqId { get; set; }
        public int? Role { get; set; }
        public int? AccountId { get; set; }
        public string Content { get; set; }
        public DateTime? AddDate { get; set; }

        public ForumQuestion Fq { get; set; }
    }
}
