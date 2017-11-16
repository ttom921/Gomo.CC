using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class RepairShopInfo
    {
        public int Id { get; set; }
        public string Vatnumber { get; set; }
        public string ShopName { get; set; }
        public string Principal { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string LineId { get; set; }
        public string FbUrl { get; set; }
        public string Wechat { get; set; }
        public string ShopImgUrl { get; set; }
        public string BusinessTime { get; set; }
        public string MaintenanceProject { get; set; }
        public string MaintenanceItems { get; set; }
        public string Email { get; set; }
        public JsonObject<string> GooglemapGeocoding { get; set; }
        public string GooglemapGeocodingIsDirty { get; set; }
    }
}
