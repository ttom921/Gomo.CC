using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class ConsumerAccount
    {
        public int Id { get; set; }
        public int? RsaId { get; set; }
        public string ConsumerId { get; set; }
        public string Password { get; set; }
        public int? Status { get; set; }
        public int? ErrorCnt { get; set; }

        public RepairShopAccount Rsa { get; set; }
    }
}
