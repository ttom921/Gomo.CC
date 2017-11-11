using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class ReportInvRecv
    {
        public int Id { get; set; }
        public int? CaId { get; set; }
        public int? RswoId { get; set; }
        public DateTime? DateOut { get; set; }
        public string WorkOrderNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int? PaymentType { get; set; }
        public string ConsumerName { get; set; }
        public int? Tax { get; set; }
        public int? Balance { get; set; }
    }
}
