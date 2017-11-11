using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class RepairShopAccount
    {
        public RepairShopAccount()
        {
            ConsumerAccount = new HashSet<ConsumerAccount>();
            ShopAccountPayable = new HashSet<ShopAccountPayable>();
        }

        public int Id { get; set; }
        public int? AaiId { get; set; }
        public string AccountNo { get; set; }
        public string Password { get; set; }
        public int? Role { get; set; }
        public int? Rank { get; set; }
        public int? Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public ICollection<ConsumerAccount> ConsumerAccount { get; set; }
        public ICollection<ShopAccountPayable> ShopAccountPayable { get; set; }
    }
}
