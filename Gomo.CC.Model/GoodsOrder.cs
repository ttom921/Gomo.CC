using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class GoodsOrder
    {
        public int Id { get; set; }
        public int? RsaId { get; set; }
        public string Rules { get; set; }
        public sbyte? Order { get; set; }
        public DateTime? OrderDate { get; set; }
        public sbyte? Ship { get; set; }
        public DateTime? ShipDate { get; set; }
        public sbyte? Pay { get; set; }
        public DateTime? PayDate { get; set; }
    }
}
