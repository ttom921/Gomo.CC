using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class UserGuide
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ContentUrl { get; set; }
        public DateTime? Adddate { get; set; }
    }
}
