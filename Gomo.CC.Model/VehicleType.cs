using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class VehicleType
    {
        public int Id { get; set; }
        public int? VmId { get; set; }
        public string CarType { get; set; }

        public VehicleModel Vm { get; set; }
    }
}
