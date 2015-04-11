using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoadRingSim.Core.Domains;

namespace RoadRingSim.Data.DAO
{
    /// <summary>
    /// класс, для работы с пользователями из базы данных
    /// </summary>
    public class UserDAO : DAO
    {

        /// <summary>
        /// сохраняет пользователя в базе данных
        /// </summary>
        /// <param name="user">сохраняемый пользователь</param>
        /// <returns>объект пользователя с присвоенным ID</returns>
        public User Insert(User user)
        {
            user.ID = GetMaxID("User") + 1;

            ExecuteQuery(
                String.Format("INSERT INTO `User`(`ID`,`Login`,`Password`,`IDRole`) VALUES ({0},{1},{2},{3});",
                user.ID, user.Login, user.Password, user.Role.ID));
            return user;
        }

        /// <summary>
        /// обновляет данные о пользователе в базе данных
        /// </summary>
        /// <param name="user">объект обновляемого пользователя</param>
        /// <returns></returns>
        public void Update(User user)
        {
            ExecuteQuery(
                String.Format("UPDATE `User` SET `Login`={1}, `Password`={2}, `IDRole`={3} WHERE `ID`={0}",
                user.ID, user.Login, user.Password, user.Role.ID)
                );
        }


        /// <summary>
        /// удаление пользователя из базы данных
        /// </summary>
        /// <param name="user">удаляемый пользователь</param>
        public void Delete(User user)
        {
            ExecuteQuery(
                String.Format(
                "DELETE FROM `User` WHERE `ID` = {0}",
                user.ID)
                );
        }

        /// <summary>
        /// получение списка всех пользователей
        /// </summary>
        /// <returns></returns>
        public List<User> SelectAll()
        {
            return Select("SELECT * FROM User");
        }

        /// <summary>
        /// получение выборки пользователей
        /// </summary>
        /// <param name="query">строка запроса к БД</param>
        /// <returns>список пользователей</returns>
        public List<User> Select(string query)
        {
            var res = new List<User>();
            var list = ExecuteQuery(query);

            foreach (var r in list)
            {
                var user = new User();
                user.ID = int.Parse(r[0].ToString());
                user.Login = r[1].ToString();
                user.Password = r[2].ToString();
                user.Role.ID = int.Parse(r[3].ToString());
                res.Add(user);
            }
            return res;
        }
    }
}
