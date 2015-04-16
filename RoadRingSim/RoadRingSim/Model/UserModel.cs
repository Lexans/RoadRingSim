using RoadRingSim.Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadRingSim.Model
{
    public class UserModel
    {
        public UserModel()
        {
            //инициализация произвольными данными
            var Roles = new List<UserRole>
            {
                new UserRole{RoleName = "Роль 1"},
                new UserRole{RoleName="Роль 2"}
            };

            Users = new List<User>
            {
                new User {Login = "1", Password="1", Role = Roles[0]},
                new User {Login = "2", Password="1", Role = Roles[1]}
            };

        }

        public List<User> Users { set; get; }
        public static List<UserRole> Role { get; set; }


        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void EditUser(User user)
        {
            
        }

        public void DeleteUser(User user)
        {
            Users.Remove(user);
        }
    }
}
