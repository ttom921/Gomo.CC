﻿using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class ConsumerProfile
    {
        public int Id { get; set; }
        public int? UserInfoId { get; set; }
        public int? CaId { get; set; }
        public int? ConsumerType { get; set; }
        public string ConsumerName { get; set; }
        public sbyte? Gender { get; set; }
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
        public sbyte? PayTypeAccount { get; set; }
        public sbyte? PayTypeCash { get; set; }
        public sbyte? PayTypeCheck { get; set; }
        public sbyte? PayTypeCredit { get; set; }
        public sbyte? PayTypeDebit { get; set; }
        public sbyte? PayTypeMasterCard { get; set; }
        public string Referralentry { get; set; }
    }
}
