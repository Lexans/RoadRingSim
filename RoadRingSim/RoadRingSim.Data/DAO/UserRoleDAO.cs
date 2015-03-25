using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoadRingSim.Core.Domains;

namespace RoadRingSim.Data.DAO
{
    class UserRoleDAO: DAO
    {

        public UserRoleDAO GetById(int id)
        {
            ExecuteQuery("select * from user_role where id=" + id).FirstOrDefault();
        }

        //дописать
        private List<Role> GetByQuery(string query)
        {
            var res = new List<User>();
            var list = ExecuteQuery(query);
            foreach (var r in list)
            {
                var user = new UserDAO();
                user.id = int.Parse(r[0].ToString());
                user.Login = r[1].ToString();
                user.Password = r[2].ToString();
                res.Add(user);
            }
            return res;
        }


        private User Update()
        {
            ...
              //роль берем из user dao
        }
    }
}
