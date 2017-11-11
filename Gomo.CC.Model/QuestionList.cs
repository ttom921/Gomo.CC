using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class QuestionList
    {
        public QuestionList()
        {
            ReplyList = new HashSet<ReplyList>();
        }

        public int Id { get; set; }
        public int? FaqcId { get; set; }
        public int? Role { get; set; }
        public int? AccountId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? AddDate { get; set; }
        public int? Answer { get; set; }

        public Faqcategory Faqc { get; set; }
        public ICollection<ReplyList> ReplyList { get; set; }
    }
}
