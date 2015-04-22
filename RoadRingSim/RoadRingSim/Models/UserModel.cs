using RoadRingSim.Core.Domains;
using RoadRingSim.Data.DAO;
using System.Collections.Generic;
using System.Linq;

namespace RoadRingSim.Models
{
    public class UserModel
    {
        public UserRoleDAO userRole = new UserRoleDAO();
        public UserDAO user;
        public List<User> Users { set; get; }
        public static List<UserRole> Role { get; set; }

        public UserModel(UserDAO user)
        {
            this.user = user;
            Role = userRole.SelectAll();
            Users = user.SelectAllWithoutRoleName();
            Users.ForEach(x => x.Role.RoleName = Role.Single<UserRole>(y => y.ID == x.Role.ID).RoleName);
        }
        
        public void AddUser(User user)
        {
            Users.Add(this.user.Insert(user));
        }
        public void EditUser(User user)
        {
            this.user.Update(user);
            Users.RemoveAll(x => x.ID == user.ID);
            Users.Add(user);
        }
        public void DeleteUser(User user)
        {
            this.user.Delete(user);
            
            Users.Remove(user);
        }
    }
}
