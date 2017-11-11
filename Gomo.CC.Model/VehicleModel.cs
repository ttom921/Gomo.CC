using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class VehicleModel
    {
        public VehicleModel()
        {
            VehicleType = new HashSet<VehicleType>();
        }

        public int Id { get; set; }
        public int? VcId { get; set; }
        public string CarModel { get; set; }

        public VehicleCategory Vc { get; set; }
        public ICollection<VehicleType> VehicleType { get; set; }
    }
}
