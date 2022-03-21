using System.Data;
using System.IO;
using System.Text.Json;
using MySql.Data.MySqlClient;

namespace TestProject1.Utils
{
    public static class SqlUtil
    {
        private static readonly MySqlConnection Connection;

        static SqlUtil()
        {
            using (var reader = new StreamReader("settings.json"))
            {
                var dbConnection = JsonSerializer.Deserialize<DbConnetion>(reader.ReadToEnd());
                Connection = new MySqlConnection($"server={dbConnection.Server};port={dbConnection.Port};username={dbConnection.UserName};password={dbConnection.Password};database={dbConnection.DataBase}");
            }
        }

        public static DataTable GetTableBySqlRequest(string sqlFilePath)
        {
            Connection.Open(); 
            var table = new DataTable();
            using (var reader = new StreamReader(sqlFilePath))
            { 
                var command = new MySqlCommand(reader.ReadToEnd(),Connection);
                var adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
            }
            Connection.Close();
            return table;
        }
    }
}