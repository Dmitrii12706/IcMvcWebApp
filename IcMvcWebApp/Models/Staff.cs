

namespace IcMvcWebApp.Models
{
    public class Staff
    {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Location { get; set; }
            public string RoleName { get; set; }
            public string Archivied { get; set; }
            
            public int? RoleID { get; set; }
            public Role Role { get; set; }
    }
}
