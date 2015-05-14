using System.Collections.Generic;

namespace RoadRingSim.Core.Domains
{
    /// <summary>
    /// модель ролей проьзователей
    /// </summary>
    public class UserRole:DomainObject
    {
        public UserRole(UserRole role)
        {
            this.ID = role.ID;
            this.RoleName = role.RoleName;
            this.Users = role.Users;
        }
        public UserRole(int id)
        {
            this.ID = id;
        }
        public string RoleName { get; set;}

        /// <summary>
        /// список всех пользователей с данной ролью
        /// </summary>
        public List<User> Users { get; set;}

        public override string ToString()
        {
            return this.RoleName;
        }
    }
}
