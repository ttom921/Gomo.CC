using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class ReportCustCar
    {
        public int Id { get; set; }
        public int? RswoId { get; set; }
        public DateTime? DateOut { get; set; }
        public string WorkOrderNumber { get; set; }
        public string LicensePlateNumber { get; set; }
        public string ConsumerName { get; set; }
        public string StaffName { get; set; }
        public int? HourPay { get; set; }
        public double? Hours { get; set; }
        public string CarName { get; set; }
        public int? PartAmt { get; set; }
        public int? LaborAmt { get; set; }
        public int? Disc { get; set; }
        public int? Tax { get; set; }
        public int? Balance { get; set; }
        public int? Cost { get; set; }
        public int? Profit { get; set; }
        public int? Salary { get; set; }
        public double? UnitRewardRate { get; set; }
    }
}
