using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class AccountPay
    {
        public int Id { get; set; }
        public int? RepairShopInfoId { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string InvoiceNumber { get; set; }
        public string SuppilerName { get; set; }
        public string CheckNumber { get; set; }
        public string Bank { get; set; }
        public string BankAccount { get; set; }
        public int? PaymentTerms { get; set; }
        public string Total { get; set; }
        public int? PaymentMethod { get; set; }
    }
}
