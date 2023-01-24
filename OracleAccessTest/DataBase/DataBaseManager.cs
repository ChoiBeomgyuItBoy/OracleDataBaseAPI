using System;
using System.Data;
using System.Data.OracleClient;
using System.Linq;

namespace OracleAccessTest.DataBase
{
    public static class DataBaseManager
    {
        readonly static string dataSource = "xe";
        readonly static string password = "kobe2000";
        readonly static string userID = "system";

        private static OracleConnection GetFromConnectionString()
        {
            return new OracleConnection($"DATA SOURCE = {dataSource} ; PASSWORD = {password} ; USER ID = {userID} ;");
        }

        public static bool AlreadyHasKey(string tableName, string tableKey, string key)
        {
            using (OracleConnection connection = GetFromConnectionString())
            {
                connection.Open();

                string query = $"SELECT 1 FROM {tableName} WHERE {tableKey} = :keyValue";

                OracleCommand command = new OracleCommand(query, connection);

                command.Parameters.AddWithValue(":keyValue", key);

                OracleDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// NOTE: The parameters from the T class should match the table parameters in order for this method to work
        /// </summary>
        public static T GetItemWithKey<T>(string tableName, string tableKey, string key) where T : new()
        {
            using (OracleConnection connection = GetFromConnectionString())
            {
                connection.Open();

                string query = $"SELECT * FROM {tableName} WHERE {tableKey} = :key";

                OracleCommand command = new OracleCommand(query, connection);

                command.Parameters.Add(new OracleParameter("key", key));

                OracleDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        // Mapping row values to item
                        T item = new T();
                        var properties = typeof(T).GetProperties();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var prop = properties.FirstOrDefault(p => p.Name.Equals(reader.GetName(i), StringComparison.InvariantCultureIgnoreCase));
                            if (prop != null)
                            {
                                // Handling int or long data type for mapping
                                if (prop.PropertyType == typeof(int) || prop.PropertyType == typeof(int?))
                                {
                                    var val = reader.IsDBNull(i) ? null : (int?)Convert.ToInt32(reader.GetValue(i));
                                    prop.SetValue(item, val);
                                }
                                else if (prop.PropertyType == typeof(long) || prop.PropertyType == typeof(long?))
                                {
                                    var val = reader.IsDBNull(i) ? null : (long?)Convert.ToInt64(reader.GetValue(i));
                                    prop.SetValue(item, val);
                                }
                                else
                                {
                                    var val = reader.IsDBNull(i) ? null : reader.GetValue(i);
                                    prop.SetValue(item, val);
                                }
                            }
                        }

                        return item;
                    }
                }

                return default(T);
            }
        }

        public static DataTable GetDataTable(string tableName)
        {
            using (OracleConnection connection = GetFromConnectionString())
            {
                connection.Open();

                string query = $"SELECT * FROM {tableName}";

                OracleCommand command = new OracleCommand(query, connection);

                OracleDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();

                if(reader.Read())
                {
                    dataTable.Load(reader);
                }

                return dataTable;
            }
        }

        public static int GetMaxAttributeSize(string tableName, string attributeName)
        {
            using (OracleConnection connection = GetFromConnectionString())
            {
                connection.Open();

                string query = "SELECT data_length FROM all_tab_columns WHERE table_name = :tableName AND column_name = :columnName";

                OracleCommand command = new OracleCommand(query, connection);

                command.Parameters.Add(new OracleParameter("tableName", tableName));
                command.Parameters.Add(new OracleParameter("columnName", attributeName));

                OracleDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    return reader.GetInt32(0);                    
                }

                return 0;
            }
        }

        public static bool InsertData(IDataInserter inserter)
        {
            using (OracleConnection connection = GetFromConnectionString())
            {
                connection.Open();

                var insertionData = inserter.GetInsertionData();

                var columnNames = string.Join(",", insertionData.Keys);
                var columnValues = string.Join(",", insertionData.Keys.Select(k => ":" + k));

                string query = $"INSERT INTO {inserter.GetInsertionTableName()} ({columnNames}) VALUES ({columnValues})";

                OracleCommand command = new OracleCommand(query, connection);

                foreach(var item in insertionData)
                {
                    command.Parameters.Add(new OracleParameter(item.Key, item.Value));
                }

                int rowsAffected = command.ExecuteNonQuery();

                if(rowsAffected == 0)
                {
                    return false;
                }

                return true;
            }
        }

        public static bool ModifyData(IDataModifier modifier)
        {
            using (OracleConnection connection = GetFromConnectionString())
            {
                connection.Open();

                var modifyingData = modifier.GetDataToModify();
                
                var setClause = string.Join(",", modifyingData.Select(d => d.Key + "=:" + d.Key));

                string query = $"UPDATE {modifier.GetModifyingTableName()} SET {setClause} WHERE {modifier.GetModifyingWhereClause()}";

                OracleCommand command = new OracleCommand(query, connection);

                foreach(var item in modifyingData)
                {
                    command.Parameters.Add(new OracleParameter(item.Key, item.Value));
                }

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    return false;
                }

                return true;
            }
        }

        public static bool DeleteItemWithKey(string tableName, string tableKey, string key)
        {
            using (OracleConnection connection = GetFromConnectionString())
            {
                connection.Open();

                string query = $"DELETE FROM {tableName} WHERE {tableKey} = :keyValue";

                OracleCommand command = new OracleCommand(query, connection);

                command.Parameters.Add(new OracleParameter("keyValue", key));

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    return false;
                }

                return true;
            }
        }
    }
}