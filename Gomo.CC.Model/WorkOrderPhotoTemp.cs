using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class WorkOrderPhotoTemp
    {
        public int Id { get; set; }
        public int? SwoId { get; set; }
        public string ImgUrl { get; set; }

        public ShopWorkOrderTemp Swo { get; set; }
    }
}
