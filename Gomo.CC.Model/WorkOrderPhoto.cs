using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class WorkOrderPhoto
    {
        public int Id { get; set; }
        public int? SwoId { get; set; }
        public string ImgUrl { get; set; }

        public ShopWorkOrder Swo { get; set; }
    }
}
