using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class AutoMessageType
    {
        public AutoMessageType()
        {
            AutoMessageSet = new HashSet<AutoMessageSet>();
        }

        public int Id { get; set; }
        public string MessageType { get; set; }

        public ICollection<AutoMessageSet> AutoMessageSet { get; set; }
    }
}
