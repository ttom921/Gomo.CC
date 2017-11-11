using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class Faqcategory
    {
        public Faqcategory()
        {
            Faqlist = new HashSet<Faqlist>();
            QuestionList = new HashSet<QuestionList>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Faqlist> Faqlist { get; set; }
        public ICollection<QuestionList> QuestionList { get; set; }
    }
}
