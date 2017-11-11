using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class AccountReceivable
    {
        public int Id { get; set; }
        public int? ShopWorkOrderHistoryId { get; set; }
        public decimal? SubTotabl { get; set; }
        public decimal? Tax { get; set; }
        public decimal? Total { get; set; }
        public decimal? Paid { get; set; }
        public decimal? Balance { get; set; }
        public int? PaymentMethod { get; set; }
        public DateTime? ReceivableDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string Note { get; set; }
        public string Payer { get; set; }
        public bool? Settle { get; set; }
    }
}
