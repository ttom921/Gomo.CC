using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class ImgServer
    {
        public int Id { get; set; }
        public string ServerIp { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Path { get; set; }
        public int? Status { get; set; }
    }
}
