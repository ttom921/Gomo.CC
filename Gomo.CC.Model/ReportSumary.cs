using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class ReportSumary
    {
        public int Id { get; set; }
        public int? ReportId { get; set; }
        public int? Amount { get; set; }
    }
}
