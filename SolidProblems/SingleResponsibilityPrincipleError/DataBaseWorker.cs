using System;
using System.Collections.Generic;
using System.Data.Common;
using MySqlConnector;

namespace SolidProblems.SingleResponsibilityPrincipleError
{
    /// <summary>
    /// This class not support Single Responsibility Principle, because this class is God's class.
    /// It support operation connection to db and working with db data. I think that this functional
    /// must support two classes.
    /// </summary>
    public class DataBaseWorker
    {
        private MySqlConnection _connection;

        private void InitializeConnection(string host, int port, string database,
            string username, string password)
        {
            var connectionString = "Server=" + host + ";Database=" + database +
                                   ";port=" + port + ";User Id=" + username + ";password=" + password;
            this._connection = new MySqlConnection(connectionString);
        }

        public DataBaseWorker(string host, int port, string database,
            string username, string password)
        {
            this.InitializeConnection(host, port, database, username, password);
        }

        public List<string> GetAllNames()
        {
            var result = new List<string>();
            this._connection.Open();
            string sql = "Select * from actor";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this._connection;
            cmd.CommandText = sql;
            try
            {
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int actorNameIndex = reader.GetOrdinal("first_name");
                            string actorName = reader.GetString(actorNameIndex);
                            result.Add(actorName);
                        }
                    }
                }
            }
            finally
            {
                this._connection.Close();
                this._connection.Dispose();
            }

            return result;
        }
    }
}
