using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class GoodsQuestion
    {
        public GoodsQuestion()
        {
            GoodsAnswer = new HashSet<GoodsAnswer>();
        }

        public int Id { get; set; }
        public int? GlId { get; set; }
        public int? RsaId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? AddDate { get; set; }

        public GoodsList Gl { get; set; }
        public ICollection<GoodsAnswer> GoodsAnswer { get; set; }
    }
}
