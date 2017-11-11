using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class AuthorityPoint
    {
        public int Id { get; set; }
        public int? UserInfoId { get; set; }
        public int? AuthorityPoint1 { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
