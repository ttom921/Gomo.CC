using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class ForumQuestion
    {
        public ForumQuestion()
        {
            ForumReply = new HashSet<ForumReply>();
        }

        public int Id { get; set; }
        public int? Role { get; set; }
        public int? AccountId { get; set; }
        public int? FcId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? AddDate { get; set; }
        public int? ViewCount { get; set; }

        public ForumCategory Fc { get; set; }
        public ICollection<ForumReply> ForumReply { get; set; }
    }
}
