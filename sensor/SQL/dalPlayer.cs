using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace sensor.models
{
    public class DalPlayer
    {
        MySql mySql;
        public DalPlayer(MySql mysql)
        {
            mySql = mysql;
        }


        // בודקת אם השחקן כבר רשום ומחזירה אותו
        public Player FindByFuulName(List<string> fullName)
        {
            Player player = null;
            try
            {
                MySqlConnection conn = mySql.GetConnection();
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM players WHERE first_name = @firstname AND last_name = @lastname", conn);
                cmd.Parameters.AddWithValue("@firstname", fullName[0]);
                cmd.Parameters.AddWithValue("@lastname", fullName[1]);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string firstName = reader.GetString("first_name");
                    string lastName = reader.GetString("last_name");
                    int currentLevel = reader.GetInt32("current_level");
                    int numberOfWins = reader.GetInt32("number_of_wins");
                    player = new Player(id,firstName, lastName, currentLevel, numberOfWins);
                }
                return player;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error:{ex.Message}");
                return player;
            }
            finally
            {
                mySql.close();
            }
        }
    


        // יוצרת אדם חדש ומוסיפה לרשימה
        public bool AddPersonToTable(List<string> fullName)
        {
            bool x = false;
            Player player = null;
            Random rnd = new Random();
            try
            {
                MySqlConnection conn = mySql.GetConnection();
                MySqlCommand cmd = new MySqlCommand(@"INSERT INTO players (first_name,last_name,current_level,number_of_wins)
                             VALUES(@first_name,@last_name,@current_level,@number_of_wins)", conn);
                cmd.Parameters.AddWithValue("@first_name", fullName[0]);
                cmd.Parameters.AddWithValue("@last_name", fullName[1]);
                cmd.Parameters.AddWithValue("@current_level", 1); 
                cmd.Parameters.AddWithValue("@number_of_wins", 0);
                int rowsAffected = cmd.ExecuteNonQuery(); // כמה שורות הושפעו
                return rowsAffected > 0;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error:{ex.Message}");
                return false;
            }
            finally
            {
                mySql.close();
            }
        }

        //  יצירת אוביייקט מתוך הבסיס נתונים והחזרת אובייקט
        public Player CreatingLocalPerson(List<string> fullName)
        {
            Player player = null;
            try
            {
                MySqlConnection conn = mySql.GetConnection();
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM players WHERE first_name = @firstname AND last_name = @lastname", conn);
                cmd.Parameters.AddWithValue("@firstname", fullName[0]);
                cmd.Parameters.AddWithValue("@lastname", fullName[1]);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string firstName = reader.GetString("first_name");
                    string lastName = reader.GetString("last_name");
                    int currentLevel = reader.GetInt32("current_level");
                    int numberOfWins = reader.GetInt32("number_of_wins");
                    player = new Player(id,firstName,lastName,currentLevel,numberOfWins);
                }

                return player;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error:{ex.Message}");
                return player;
            }
            finally
            {
                mySql.close();
            }
        }

        // עדכון שלב נוכחי
        public void AddReportToPepole(Player player)
        {
            try
            {
                MySqlConnection conn = mySql.GetConnection();
                MySqlCommand cmd = new MySqlCommand($"UPDATE players SET number_of_wins = number_of_wins+1 WHERE id = {player.Id}", conn);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error:{ex.Message}");
            }
            finally
            {
                mySql.close();
            }

        }

        // עדכון מספר ניצחונות
        public void AddWinToPlayer(Player player)
        {
            try
            {
                MySqlConnection conn = mySql.GetConnection();
                MySqlCommand cmd = new MySqlCommand($"UPDATE players SET current_level = current_level+1,number_of_wins = 0 WHERE id = {player.Id}", conn);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error:{ex.Message}");
            }
            finally
            {
                mySql.close();
            }

        }
    }
}

