using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IcMvcWebApp.Models
{
    public class Role

    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }

        public ICollection<Staff> Staff { get; set; }
    }
}
