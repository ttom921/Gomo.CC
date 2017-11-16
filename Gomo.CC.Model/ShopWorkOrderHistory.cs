using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class ShopWorkOrderHistory
    {
        public int Id { get; set; }
        public int? RepairShopInfoId { get; set; }
        public string WorkOrderNumber { get; set; }
        public string LicensePlateNumber { get; set; }
        public string Driver { get; set; }
        public string Telphone { get; set; }
        public string Cellphone { get; set; }
        public string CarInformation { get; set; }
        public string Color { get; set; }
        public string ConsumerImgUrl { get; set; }
        public sbyte? Maintenance { get; set; }
        public sbyte? Overhaul { get; set; }
        public sbyte? Insurance { get; set; }
        public sbyte? Claim { get; set; }
        public sbyte? Pdi { get; set; }
        public sbyte? Courtesy { get; set; }
        public sbyte? Towing { get; set; }
        public string CourtesyLicenseplateNumber { get; set; }
        public string Technician { get; set; }
        public string Staff { get; set; }
        public string WorkPurpose { get; set; }
        public string Wpddescription { get; set; }
        public string MaintenanceAdvice { get; set; }
        public DateTime? NextMaintenanceDate { get; set; }
        public DateTime? DateIn { get; set; }
        public string MileageIn { get; set; }
        public DateTime? DateOut { get; set; }
        public string MileageOut { get; set; }
        public string PlannedHours { get; set; }
        public string RealHours { get; set; }
        public string TotalBeforeTax { get; set; }
        public string DiscountAgain { get; set; }
        public string Tax { get; set; }
        public string Total { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
    }
}
