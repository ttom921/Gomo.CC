using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class MessageRecord
    {
        public int Id { get; set; }
        public int? RsaId { get; set; }
        public int? CaId { get; set; }
        public int? MessageType { get; set; }
        public string MessageContent { get; set; }
        public int? MediaType { get; set; }
        public DateTime? RecordDate { get; set; }
        public sbyte? Success { get; set; }
    }
}
