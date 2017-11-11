using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class GoodsOrder
    {
        public int Id { get; set; }
        public int? RsaId { get; set; }
        public string Rules { get; set; }
        public bool? Order { get; set; }
        public DateTime? OrderDate { get; set; }
        public bool? Ship { get; set; }
        public DateTime? ShipDate { get; set; }
        public bool? Pay { get; set; }
        public DateTime? PayDate { get; set; }
    }
}
