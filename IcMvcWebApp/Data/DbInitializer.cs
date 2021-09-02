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

            var staffs = new Staff[]
            {
            new Staff{FirstName="Carson",LastName="Alexander",Location="Auckland",RoleName="Tutor"},
            new Staff{FirstName="Dmitrii",LastName="Kotov",Location="Auckland",RoleName="Tutor"},
            new Staff{FirstName="Nina",LastName="Bespalova",Location="Auckland",RoleName="Tutor"},
            new Staff{FirstName="Denis",LastName="Ten",Location="Auckland",RoleName="Student"},
            new Staff{FirstName="Liza",LastName="Alpach",Location="Aus",RoleName="Student"},//,Archivied=""
            };
            foreach (Staff s in staffs)
            {
                context.Staffs.Add(s);
            }
            context.SaveChanges();

            var roles = new Role[]
            {
            new Role{RoleName="Tutor"},
            new Role{RoleName="Student"},
            };
            foreach (Role e in roles)
            {
                context.Roles.Add(e);
            }
            context.SaveChanges();
        }
    }
}
