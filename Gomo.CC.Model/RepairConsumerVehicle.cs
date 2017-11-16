using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class RepairConsumerVehicle
    {
        public int Id { get; set; }
        public int? RcpId { get; set; }
        public string LicensePlateNumber { get; set; }
        public int? VcId { get; set; }
        public int? VmId { get; set; }
        public int? VtId { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public string Milage { get; set; }
        public string ImgUrl { get; set; }
        public string NextMaintainMileage { get; set; }
        public DateTime? DateOfManufcture { get; set; }
        public DateTime? InspectionDate { get; set; }
        public DateTime? InsuranceExpirationDate { get; set; }
        public sbyte OnChange { get; set; }

        public RepairConsumerProfile Rcp { get; set; }
    }
}
