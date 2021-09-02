

namespace IcMvcWebApp.Models
{
    public class Staff
    {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Location { get; set; }

            /// <summary>
            /// Зачем тебе данные дважды дублировать???
            /// У тебя в классе-модели уже есть это свойство.
            /// Ты переполняешь таблицу бесполезными данными.
            /// Загугли "нормализация данных вбазах данных".
            /// </summary>
            //public string RoleName { get; set; }
            public bool Archivied { get; set; }
                    
            public int? RoleID { get; set; }
            public Role Role { get; set; }
    }
}
