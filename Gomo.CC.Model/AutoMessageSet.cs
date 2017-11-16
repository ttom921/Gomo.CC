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
        public sbyte? MediaTypeSms { get; set; }
        public sbyte? MediaTypeLine { get; set; }
        public sbyte? MediaTypeMessenger { get; set; }
        public sbyte? MediaTypeWechat { get; set; }
        public sbyte? Status { get; set; }

        public AutoMessageType MessageTypeNavigation { get; set; }
    }
}
