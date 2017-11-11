using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class RepairConsumerProfile
    {
        public RepairConsumerProfile()
        {
            RepairConsumerVehicle = new HashSet<RepairConsumerVehicle>();
        }

        public int Id { get; set; }
        public int? RepairShopInfoId { get; set; }
        public int? ConsumerProfileId { get; set; }
        public int? CaId { get; set; }
        public int? ConsumerType { get; set; }
        public string ConsumerId { get; set; }
        public string ConsumerName { get; set; }
        public string Driver { get; set; }
        public int? Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Cellphone { get; set; }
        public string Fburl { get; set; }
        public string LineId { get; set; }
        public string WechatId { get; set; }
        public string Sms { get; set; }
        public string Discount { get; set; }
        public bool? PayTypeAccount { get; set; }
        public bool? PayTypeCash { get; set; }
        public bool? PayTypeCheck { get; set; }
        public bool? PayTypeCredit { get; set; }
        public bool? PayTypeDebit { get; set; }
        public bool? PayTypeMasterCard { get; set; }
        public string Referralentry { get; set; }
        public string Quota { get; set; }
        public string UsedQuota { get; set; }

        public ICollection<RepairConsumerVehicle> RepairConsumerVehicle { get; set; }
    }
}
