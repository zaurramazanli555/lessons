using System.Collections.Generic;

namespace WindowsFormsAppPart2
{
    public class VirtualDatabase
    {
        public static List<User> Users = new List<User>();

        static VirtualDatabase()
        {
            Users.Add(new User() {
                Id = 1,
                Name = "Orkhan",
                Surname = "Farajov",
                Username = "orkhanfarajov",
                Password = "orkhan123456"
            });

            Users.Add(new User() {
                Id = 2,
                Name = "Ruslan",
                Surname = "Valibayli",
                Username = "ruslanvalibayli",
                Password = "ruslan123456"
            });

            Users.Add(new User() {
                Id = 3,
                Name = "Zaur",
                Surname = "Ramazanli",
                Username = "zaurramazanli",
                Password = "zaur123456"
            });
        }
    }
}
