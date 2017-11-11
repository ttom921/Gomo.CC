using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class Reservation
    {
        public int Id { get; set; }
        public int? RepairShopInfoId { get; set; }
        public DateTime ReserDateTime { get; set; }
        public string Cellphone { get; set; }
        public int? UserInfoId { get; set; }
        public string CustomerName { get; set; }
        public string Gender { get; set; }
        public string Vatnumber { get; set; }
        public string LicensePlateNumber { get; set; }
        public bool? Maintenance { get; set; }
        public bool? Overhaul { get; set; }
        public bool? Insurance { get; set; }
        public bool? Claim { get; set; }
        public bool? Pdi { get; set; }
        public bool? Courtesy { get; set; }
        public bool? Towing { get; set; }
        public string Notes { get; set; }
        public int? DelFlag { get; set; }
    }
}
