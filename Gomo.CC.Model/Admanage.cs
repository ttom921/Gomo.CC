using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class Admanage
    {
        public int Id { get; set; }
        public int AiId { get; set; }
        public int Adtype { get; set; }
        public string Adname { get; set; }
        public string Adurl { get; set; }
        public bool? Adstatus { get; set; }
        public DateTime AddDate { get; set; }
    }
}
