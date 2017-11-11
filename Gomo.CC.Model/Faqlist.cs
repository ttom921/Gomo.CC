using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class Faqlist
    {
        public int Id { get; set; }
        public int? FaqcId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? AddDate { get; set; }

        public Faqcategory Faqc { get; set; }
    }
}
