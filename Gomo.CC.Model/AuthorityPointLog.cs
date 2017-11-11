using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class AuthorityPointLog
    {
        public int Id { get; set; }
        public int UserInfoId { get; set; }
        public int ParentId { get; set; }
        public int? AuthorityPoint { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string Description { get; set; }
    }
}
