using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class ReportOverall
    {
        public int Id { get; set; }
        public int? ServiceCount { get; set; }
        public int? PayAmount { get; set; }
        public double? WaitingHours { get; set; }
        public double? InventoryRatio { get; set; }
    }
}
