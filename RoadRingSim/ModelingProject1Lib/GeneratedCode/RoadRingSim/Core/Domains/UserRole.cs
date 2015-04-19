using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim.Core.Domains
{
	public sealed class UserRole : DomainObject
	{
		public string RoleName;

		public List<User> Users;

		public UserRole()
		{
		}

	}
}

