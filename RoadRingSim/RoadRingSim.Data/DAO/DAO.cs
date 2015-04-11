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
        private static SQLiteConnection _connection;
        
        public static SQLiteConnection Connection
        {
            get {
                if(_connection == null)
                {
                    //название файла бд и кодировка
                    var connectionString = "data source = roadRing.db; New=True; UseUTF16Encoding=TRUE";
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
        /// выполнение запросов к базе данных
        /// </summary>
        /// <param name="query">строка запроса</param>
        /// <returns>таблица результата. Первая размерность - строка. Вторая размерность - столбец</returns>
        public List<List<object>> ExecuteQuery(string query)
        {
            var res = new List<List<object>>();
            var command = Connection.CreateCommand();
            command.CommandText = query;

            var reader = command.ExecuteReader();
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
        protected int GetMaxID(string tableName)
        {
            int id = 0;
            var maxId = ExecuteQuery("SELECT max(ID) from " + tableName);
            if (maxId.Count > 0 && maxId[0][0].ToString().Length > 0)
                id = Int32.Parse((String)maxId[0][0]);
            
            return id;
        }
    }
}
