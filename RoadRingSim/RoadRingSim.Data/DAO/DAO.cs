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

    /// <summary>
    /// базовый класс для классов работы с базой данных
    /// </summary>
    public class DAO
    {
        private static string dbName = @"RoadRingSim.db";
        private static SQLiteConnection _connection;
        
        public static SQLiteConnection Connection
        {
            get {
                if(_connection == null)
                {
                    //название файла бд и кодировка
                    var connectionString = string.Format("data source={0}",dbName);
                    _connection = new SQLiteConnection(connectionString);
                    if (_connection.State != ConnectionState.Open)
                    {
                        _connection.Open();
                    }
                }
                return _connection;
            }
        }

        /// <summary>
        /// выполнение запросов к базе данных
        /// </summary>
        /// <param name="query">строка запроса</param>
        /// <returns>таблица результата. Первая размерность - строка. Вторая размерность - столбец</returns>
        public static List<List<object>> ExecuteQuery(string query)
        {
            var res = new List<List<object>>();
            SQLiteCommand command = Connection.CreateCommand();
            command.CommandText = query;//"SELECT * FROM User";
            SQLiteDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                var list = new List<object>();
                for (int i = 0; i < reader.FieldCount; i++)
                    list.Add(reader[i]);
                res.Add(list);
            }

            return res;
        }

        /// <summary>
        /// получение максимального идентификатора записи в таблице
        /// </summary>
        /// <param name="tableName">имя таблицы</param>
        /// <returns>максимальный идентификатор записи в таблице</returns>
        protected static int GetMaxID(string tableName)
        {
            int id = 0;
            var maxId = ExecuteQuery(string.Format("SELECT max(ID) FROM {0}", tableName));
            if (maxId.Count > 0 && maxId[0][0].ToString().Length > 0)
                id = Convert.ToInt32(maxId[0][0]);
            
            return id;
        }
    }
}
