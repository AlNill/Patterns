using System.Collections.Generic;
using System.Data.Common;
using MySqlConnector;

namespace SolidProblems.SingleResponsibilityPrinciple
{
    /// <summary>
    /// For resolve God's class was made 2 classes - DataBaseConnector and DataBaseGateways.
    /// Class DatabaseGateways support data operations.
    /// </summary>
    public static class DataBaseGateways
    {
        public static List<string> GetAllNames(MySqlConnection connection)
        {
            var result = new List<string>();
            connection.Open();
            string sql = "Select * from actor";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
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
                connection.Close();
                connection.Dispose();
            }
            return result;
        }
    }
}
