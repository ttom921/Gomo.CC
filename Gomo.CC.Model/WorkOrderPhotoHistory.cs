using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class WorkOrderPhotoHistory
    {
        public int Id { get; set; }
        public int? ShopWorkOrderHistoryId { get; set; }
        public string ImgUrl { get; set; }
    }
}
