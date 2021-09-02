using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IcMvcWebApp.Models;

namespace IcMvcWebApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MvcContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Staffs.Any())
            {
                return;   // DB has been seeded
            }
            var roles = new List<Role>
            {
                new Role{RoleName="Tutor"},
                new Role{RoleName="Student"},
            };
            
            context.AddRange(roles);   
            context.SaveChanges();

            var staffs = new List<Staff>
            {
                new Staff{FirstName="Carson",LastName="Alexander",Location="Auckland", Archivied=true, Role=roles[0]},
                new Staff{FirstName="Dmitrii",LastName="Kotov",Location="Auckland", Archivied=false, Role=roles[1]},
                new Staff{FirstName="Nina",LastName="Bespalova",Location="Auckland", Archivied=true, Role=roles[0]},
                new Staff{FirstName="Denis",LastName="Ten",Location="Auckland", Archivied=true, Role=roles[1]},
                new Staff{FirstName="Liza",LastName="Alpach",Location="Aus", Archivied=false, Role=roles[0]},//,Archivied=""
            };
            
            context.AddRange(staffs);   

            context.SaveChanges();
        }
    }
}
