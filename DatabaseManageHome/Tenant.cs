using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseManageHome
{
    internal class Tenant
    {
        public int TenantID { get; set; }
        public string TenantName { get; set; }
        public string TenantVorname { get; set; }
        public string TenantContact { get; set; }
        public int HousID { get; set; }
    }
}
