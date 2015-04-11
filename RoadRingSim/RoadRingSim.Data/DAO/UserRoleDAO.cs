using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoadRingSim.Core.Domains;

namespace RoadRingSim.Data.DAO
{

    /// <summary>
    /// класс работы с таблицей "роль_пользователей"
    /// </summary>
    class UserRoleDAO: DAO
    {
        /// <summary>
        /// получение объекта роли по ID роли
        /// </summary>
        /// <param name="id"></param>
        /// <returns>роль с нужным ID</returns>
        public UserRole SelectById(int id)
        {
            UserRole role = new UserRole();
            role.RoleName = 
            (String)(ExecuteQuery("SELECT `RoleName` FROM UserRole WHERE ID=" + id).FirstOrDefault())[0];

            return role;
        }

        /// <summary>
        /// обновление списка пользователей с заданной ролью в поле Users
        /// </summary>
        /// <param name="role">роль, в которой нужно инициализировать поле Users</param>
        /// <returns>роль с инициализированным полем Users</returns>
        public UserRole UpdateUserRole(UserRole role)
        {
            UserDAO ud = new UserDAO();
            role.Users = ud.Select("SELECT * FROM `User` WHERE RoleID=" + role.ID);

            return role;
        }
    }
}
