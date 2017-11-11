using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class ForumCategory
    {
        public ForumCategory()
        {
            ForumQuestion = new HashSet<ForumQuestion>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }

        public ICollection<ForumQuestion> ForumQuestion { get; set; }
    }
}
