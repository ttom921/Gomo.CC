using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class VehicleCategory
    {
        public VehicleCategory()
        {
            VehicleModel = new HashSet<VehicleModel>();
        }

        public int Id { get; set; }
        public string CarLabel { get; set; }

        public ICollection<VehicleModel> VehicleModel { get; set; }
    }
}
