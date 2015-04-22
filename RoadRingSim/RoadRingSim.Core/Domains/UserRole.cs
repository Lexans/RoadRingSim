using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadRingSim.Core.Domains
{
    /// <summary>
    /// модель ролей проьзователей
    /// </summary>
    public class UserRole:DomainObject
    {
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
