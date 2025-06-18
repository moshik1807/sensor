using MySql.Data.MySqlClient;
namespace sensor.models
{
    public class MySql
    {
        static private string connectionString = "Server=localhost;Database=sensor;User=root;Password='';";
        private MySqlConnection connection;

        public void Connect()
        {
            var conn = new MySqlConnection(connectionString);
            connection = conn;
            try
            {
                conn.Open();
                Console.WriteLine("connected to mySql database successfully");
                conn.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error connection to mySql database: {ex.Message}");
            }
        }

        public MySqlConnection GetConnection()
        {
            try
            {
                var conn = new MySqlConnection(connectionString);
                connection = conn;
                connection.Open();
                return connection;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return connection;
            }
        }
        public void close()
        {
            var conn = new MySqlConnection(connectionString);
            connection = conn;
            connection.Close();
        }


    }
}

