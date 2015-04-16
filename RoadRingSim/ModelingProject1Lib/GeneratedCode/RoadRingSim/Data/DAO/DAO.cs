using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace RoadRingSim.Data.DAO
{
	public class DAO
	{
		public static readonly SQLiteConnection Connection;

		private static SQLiteConnection _connection;

		public virtual List<List<Object>> ExecuteQuery(string query)
		{
			throw new System.NotImplementedException();
		}

		protected virtual int GetMaxID(string tableName)
		{
			throw new System.NotImplementedException();
		}

		public DAO()
		{
		}

	}
}

