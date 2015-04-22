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
    public class UserRoleDAO: DAO
    {
        public UserRole userRole;
        /// <summary>
        /// получение объекта роли по ID роли
        /// </summary>
        /// <param name="id"></param>
        /// <returns>роль с нужным ID</returns>
        public UserRole SelectById(int id)
        {
            UserRole role = new UserRole(id);
            role.RoleName = (String)(ExecuteQuery(
                string.Format("SELECT RoleName FROM UserRole WHERE ID={0}", id)).FirstOrDefault())[0];
            return role;
        }

        /// <summary>
        /// возвращает список ролей
        /// </summary>
        /// <returns>список ролей из БД</returns>
        public List<UserRole> SelectAll()
        {
            return Select(string.Format("SELECT * FROM UserRole"));
        }
        /// <summary>
        /// возвращает список ролей соответствующих запросу
        /// </summary>
        /// <param name="query">запрос для БД</param>
        /// <returns>список ролей</returns>
        public List<UserRole> Select(string query)
        {
            var res = new List<UserRole>();
            var list = ExecuteQuery(query);

            foreach (var r in list)
            {
                var userRole = new UserRole(Convert.ToInt32(r[0]));
                userRole.RoleName = r[1].ToString();
                res.Add(userRole);
            }
            return res;
        }
    }
}
