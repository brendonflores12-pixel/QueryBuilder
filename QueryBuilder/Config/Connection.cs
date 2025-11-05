using MySql.Data.MySqlClient;

namespace QueryBuilder.config
{
    public static class Connection
    {
        public static string ConnectionString = "Server=localhost;Database=studentdb;Uid=root;Pwd=root;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
