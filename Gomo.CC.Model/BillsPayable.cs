using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class BillsPayable
    {
        public int Id { get; set; }
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public DateTime? ExchangeDate { get; set; }
        public string BillsId { get; set; }
        public int? BillsAmount { get; set; }
        public int? Payable { get; set; }
    }
}
