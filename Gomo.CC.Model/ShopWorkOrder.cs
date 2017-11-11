using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class ShopWorkOrder
    {
        public ShopWorkOrder()
        {
            WorkOrderDetail = new HashSet<WorkOrderDetail>();
            WorkOrderPhoto = new HashSet<WorkOrderPhoto>();
            WorkOrderRating = new HashSet<WorkOrderRating>();
        }

        public int Id { get; set; }
        public int? RsaId { get; set; }
        public int? CaId { get; set; }
        public int? CvId { get; set; }
        public string WorkOrderNumber { get; set; }
        public bool? Maintenance { get; set; }
        public bool? Overhaul { get; set; }
        public bool? Insurance { get; set; }
        public bool? Claim { get; set; }
        public bool? Pdi { get; set; }
        public bool? Courtesy { get; set; }
        public bool? Towing { get; set; }
        public string CourtesyLicenseplateNumber { get; set; }
        public int? TssaId { get; set; }
        public int? WssaId { get; set; }
        public string WorkPurpose { get; set; }
        public string Wpdescription { get; set; }
        public string MaintenanceAdvice { get; set; }
        public DateTime? NextMaintenanceDate { get; set; }
        public DateTime? DateIn { get; set; }
        public string MileageIn { get; set; }
        public DateTime? DateOut { get; set; }
        public string MileageOut { get; set; }
        public string PlannedHours { get; set; }
        public string RealHours { get; set; }
        public int? WorkStatus { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int? PaymentType { get; set; }
        public string Balance { get; set; }
        public int? DelFlag { get; set; }
        public string DiscountAgain { get; set; }

        public ICollection<WorkOrderDetail> WorkOrderDetail { get; set; }
        public ICollection<WorkOrderPhoto> WorkOrderPhoto { get; set; }
        public ICollection<WorkOrderRating> WorkOrderRating { get; set; }
    }
}
