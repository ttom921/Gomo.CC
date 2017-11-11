using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class GoodsPhoto
    {
        public int Id { get; set; }
        public int? GlId { get; set; }
        public string ImgUrl { get; set; }

        public GoodsList Gl { get; set; }
    }
}
