using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoadRingSim.Core.Domains;

namespace RoadRingSim.Data.DAO
{
    class UserDAO: DAO
    {
        public List<User> GetAll()
        {
            return GetByQuery("SELECT * from user");
        }

        public User Save(User user)
        {
            user.Id = GetMaxID("user") + 1;
            ExecuteQuery(String.Format("Insert into user values({0}, {1}, {2})", user.Id, user.Login, user.Password));
            return user;
        }

        //если ссылокчный объект изменяется то возвращать
        public User Update(User user)
        {
            ExecuteQuery(String.Format("Update user set login={0}, password = {1})", user.Id, user.Login, user.Password));
            return user;
        }

        public void Delete(User user)
        {

        }

        private List<User> GetByQuery(string query)
        {
            var res = new List<User>();
            var list = ExecuteQuery(query);
            foreach(var r in list)
            {
                var user = new UserDAO();
                user.id = int.Parse(r[0].ToString());
                user.Login = r[1].ToString();
                user.Password = r[2].ToString();
                res.Add(user); 
            }
            return res;
        }
    }
}
