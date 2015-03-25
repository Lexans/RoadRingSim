using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoadRingSim.Core.Domains;

namespace RoadRingSim.Data.DAO
{
    class DAO
    {
        private static SQLiteConnection _connection;
        public static SQLiteConnection Connection
        {
            get {
                if(_connection == null)
                {
                    var connectionString = "data source = roadRing.db; New=True; UseUTF16Encoding=TRUE"; //название файла и кодировка
                    _connection = new SQLiteConnection(connectionString);
                    if (_connection.State == ConnectionState.Closed)
                    {
                        _connection.Open();
                    }
                }
                return _connection;
            }
        }

        /// <summary>
        /// метод выполения запросов
        /// </summary>
        /// <param name="query">строка запроса</param>
        /// <returns>список столбцов</returns>
        public List<List<object>> ExecuteQuery(string query)
        {
            var res = new List<List<object>>();
            var comand = Connection.CreateCommand();
            comand.CommandText = query;

            var reader = comand.ExecuteReader();
            while(reader.Read())
            {
                var list = new List<object>();
                for (int i = 0; i < reader.FieldCount; i++)
                    list.Add(reader[i]);
                res.Add(list);
            }

            return res;
        }

        protected int GetMaxID(string tableName)
        {
            int id = 0;
            var maxId = ExecuteQuery("SELECT max(id) from " + tableName);
            if (maxId.Count > 0 && maxId[0][0].ToString().Length > 0)
                id = int.Parse(maxId[0][0]);
            
            return id;
        }
    }
}
