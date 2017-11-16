using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class MessageNotify
    {
        public int Id { get; set; }
        public int MesTypeId { get; set; }
        public sbyte IsRead { get; set; }
        public sbyte IsSend { get; set; }
        public DateTime SubTime { get; set; }
        public int DestId { get; set; }
        public string Content { get; set; }
        public int DelFlag { get; set; }
        public string Url { get; set; }
        public int SendId { get; set; }
        public DateTime ExpTime { get; set; }
        public int? ReservationId { get; set; }
    }
}
