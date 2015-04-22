using RoadRingSim.Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace RoadRingSim.Data.DAO
{
    /// <summary>
    /// класс, для работы с пользователями из базы данных
    /// </summary>
    public class UserDAO : DAO
    {
        public User currentUser;
        /// <summary>
        /// сохраняет пользователя в базе данных
        /// </summary>
        /// <param name="user">сохраняемый пользователь</param>
        /// <returns>объект пользователя с присвоенным ID</returns>
        public User Insert(User user)
        {
            user.ID = GetMaxID("User") + 1;
            //user.Password = Convert.ToString(PassHash(user.Password));
            ExecuteQuery(
                String.Format("INSERT INTO User VALUES ({0},\"{1}\",\"{2}\",{3});",
                user.ID, user.Login, user.Password, user.Role.ID));
            return user;
        }

        /// <summary>
        /// обновляет данные о пользователе в базе данных
        /// </summary>
        /// <param name="user">объект обновляемого пользователя</param>
        /// <param name="useHashCoding">если true, то пароль при сохранении в БД будет захэширован</param>
        /// <returns>объект пользователя</returns>
        public User Update(User user)
        {
            //if (useHashCoding) user.Password = Convert.ToString(PassHash(user.Password));
            ExecuteQuery(
                String.Format("UPDATE User SET Login=\"{1}\", Password=\"{2}\", IDRole={3} WHERE ID={0}",
                user.ID, user.Login, user.Password, user.Role.ID)
                );
            return user;
        }


        /// <summary>
        /// удаление пользователя из базы данных
        /// </summary>
        /// <param name="user">удаляемый пользователь</param>
        public void Delete(User user)
        {
            int maxId = GetMaxID("User");
            ExecuteQuery(
                    string.Format("DELETE FROM User WHERE ID = {0}", user.ID));
            if (user.ID != maxId)
                ExecuteQuery(
                    string.Format("UPDATE User SET ID={0} WHERE ID={1}", user.ID, maxId));
        }

        /// <summary>
        /// получение списка всех пользователей
        /// </summary>
        /// <returns>всех пользователей из БД</returns>
        public List<User> SelectAll()
        {
            return Select("SELECT * FROM User");
        }
        /// <summary>
        /// получение списка всех пользователей без имени роли (меньше время доступа к бд)
        /// </summary>
        /// <returns>всех пользователей из БД без имен ролей</returns>
        public List<User> SelectAllWithoutRoleName()
        {
            var res = new List<User>();
            var list = ExecuteQuery("SELECT * FROM User");

            foreach (var r in list)
            {
                var user = new User();
                user.ID = Convert.ToInt32(r[0]);
                user.Login = r[1].ToString();
                user.Password = r[2].ToString();
                user.Role = new UserRole(Convert.ToInt32(r[3]));
                res.Add(user);
            }
            return res;
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
                var userRole = new UserRoleDAO();
                var user = new User();
                user.ID = Convert.ToInt32(r[0]);
                user.Login = r[1].ToString();
                user.Password = r[2].ToString();
                user.Role = userRole.SelectById(Convert.ToInt32(r[3]));
                res.Add(user);
            }
            return res;
        }
        /// <summary>
        /// запрос юзера по имени и паролю
        /// </summary>
        /// <param name="login">Login в базе данных</param>
        /// <param name="password">Пароль в базе данных, хранимый в виде хэша</param>
        /// <returns>пользователя с такими данными или null если не существует</returns>
        public User UserByLoginPassword(string login, string password)
        {
            //long passHash = PassHash(password);
            var list = Select(
                string.Format("SELECT * FROM User WHERE Login = \"{0}\" AND Password = \"{1}\"", login, password));
            User res = list.FirstOrDefault();
            currentUser = res;
            return res;
        }
        /// <summary>
        /// Генерация хэша пароля
        /// </summary>
        /// <param name="password">пароль в чистом виде</param>
        /// <returns>число, представляющее собой пароль</returns>
        private long PassHash(string password)
        {
            long passHash = 0;
            for (int i = 0; i < password.Length; i++)
                passHash = passHash + password[i].GetHashCode() * i + i;
            return passHash;
        }
    }
}
