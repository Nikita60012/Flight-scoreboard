using MySql.Data.MySqlClient;

namespace Flight_scoreboard
{
    public class Database
    {
        public MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=flight_scoreboard;charset=utf8");

        public void openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public MySqlConnection getConnection()
        {
            return conn;
        }
    }
}