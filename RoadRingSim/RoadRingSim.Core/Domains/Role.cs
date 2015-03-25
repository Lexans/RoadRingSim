using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadRingSim.Core.Domains
{
    class Role
    {
        public string rolename;
        public List<User> Users {get; set; };
    }
}
