using MySqlConnector;

namespace SolidProblems.SingleResponsibilityPrinciple
{
    /// <summary>
    /// For resolve God's class was made 2 classes - DataBaseConnector and DataBaseGateways.
    /// Class DatabaseConnector support database connection.
    /// </summary>
    public class DataBaseConnector
    {
        private MySqlConnection _connection;

        private void InitializeConnection(string host, int port, string database,
            string username, string password)
        {
            var connectionString = "Server=" + host + ";Database=" + database +
                                   ";port=" + port + ";User Id=" + username + ";password=" + password;
            this._connection = new MySqlConnection(connectionString);
        }

        public DataBaseConnector(string host, int port, string database,
            string username, string password)
        {
            this.InitializeConnection(host, port, database, username, password);
        }

        public MySqlConnection GetConnection()
        {
            return this._connection;
        }
    }
}
