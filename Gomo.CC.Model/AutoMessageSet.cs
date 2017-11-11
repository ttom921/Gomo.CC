using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class AutoMessageSet
    {
        public int Id { get; set; }
        public int RsaId { get; set; }
        public int MessageType { get; set; }
        public string MessageContent { get; set; }
        public int ExpiredDays { get; set; }
        public bool? MediaTypeSms { get; set; }
        public bool? MediaTypeLine { get; set; }
        public bool? MediaTypeMessenger { get; set; }
        public bool? MediaTypeWechat { get; set; }
        public bool? Status { get; set; }

        public AutoMessageType MessageTypeNavigation { get; set; }
    }
}
