using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class WebDriverAccessLog
    {
        public long Id { get; set; }
        public DateTime AccessTime { get; set; }
        public string ClientUser { get; set; }
        public string ClientIp { get; set; }
        public string ClientBrowser { get; set; }
        public string AccessFunctionUrl { get; set; }
        public string Status { get; set; }
        public int TimeTaken { get; set; }
    }
}
