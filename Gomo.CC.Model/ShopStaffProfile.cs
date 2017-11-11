using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class ShopStaffProfile
    {
        public int Id { get; set; }
        public int? RepairShopInfoId { get; set; }
        public int? UserInfoId { get; set; }
        public string StaffName { get; set; }
        public DateTime? Birthday { get; set; }
        public string Job { get; set; }
        public string Salary { get; set; }
        public string RestDays { get; set; }
        public string WorkHours { get; set; }
        public string Telephone { get; set; }
        public string Cellphone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public double? Rating { get; set; }
        public int? HourSalary { get; set; }
        public double? UnitRewardRate { get; set; }
    }
}
