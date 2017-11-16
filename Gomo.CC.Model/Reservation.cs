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
        public sbyte? Maintenance { get; set; }
        public sbyte? Overhaul { get; set; }
        public sbyte? Insurance { get; set; }
        public sbyte? Claim { get; set; }
        public sbyte? Pdi { get; set; }
        public sbyte? Courtesy { get; set; }
        public sbyte? Towing { get; set; }
        public string Notes { get; set; }
        public int? DelFlag { get; set; }
    }
}
