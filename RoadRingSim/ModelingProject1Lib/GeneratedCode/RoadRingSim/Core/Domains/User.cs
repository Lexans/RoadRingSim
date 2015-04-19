using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim.Core.Domains
{
	public sealed class User : DomainObject
	{
		public string Login;

		public string Password;

		public UserRole Role;

		public static User CurrentUser;

		public User()
		{
		}

	}
}

