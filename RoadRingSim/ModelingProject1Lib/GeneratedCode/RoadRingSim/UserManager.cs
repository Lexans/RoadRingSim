using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadRingSim
{
	/// <summary>
	/// управление пользователями
	/// </summary>
	public class UserManager
	{
		/// <summary>
		/// логин текущего авторизованного пользователя
		/// </summary>
		public User LoginCurrent;

		/// <summary>
		/// тип текущего авторизованного пользователя
		/// </summary>
		public UserRang RangCurrent;

		/// <summary>
		/// авторизация по логину. Сверяются MD5 контрольные суммы из бд
		/// </summary>
		public virtual void Authorization(string Login, object Password)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// удаление юзера из бд по логину
		/// </summary>
		public virtual void DeleteUser(string Login)
		{
			throw new System.NotImplementedException();
		}

		public virtual void CreateUser(string Login, string Password)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// установка уровня пользователя в бд
		/// </summary>
		public virtual void SetRang(string Login, object UserRang)
		{
			throw new System.NotImplementedException();
		}

	}
}

