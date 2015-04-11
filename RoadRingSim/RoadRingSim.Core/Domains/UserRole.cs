using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadRingSim.Core.Domains
{

    /// <summary>
    /// соответвие ID роли уровню пользователя
    /// </summary>
    public enum UserRoles
    {
        User = 1, ExtUser = 2, SuperUser = 3
    }


    /// <summary>
    /// модель ролей проьзователей
    /// </summary>
    public class UserRole:DomainObject
    {
        public string RoleName { get; set;}

        /// <summary>
        /// список всех пользователей с данной ролью
        /// </summary>
        public List<User> Users { get; set;}
    }
}
