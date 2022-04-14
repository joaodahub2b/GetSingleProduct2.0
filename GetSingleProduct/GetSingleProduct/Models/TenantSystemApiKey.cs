using System;
using System.Collections.Generic;

#nullable disable

namespace GetSingleProduct
{
    public partial class TenantSystemApiKey
    {
        public int IdtTenantSystemApiKey { get; set; }
        public int? IdTenantSystem { get; set; }
        public string IdSystem { get; set; }
        public int? IdTenant { get; set; }
        public string IdApiKey { get; set; }
        public string Value { get; set; }
        public int? Store { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
