using System.Data;
using System.IO;
using System.Text.Json;
using MySql.Data.MySqlClient;

namespace TestProject1
{
    
    
    public static class SqlUtil
    {
        private static MySqlConnection _connection;

        static SqlUtil()
        {
            using (var reader = new StreamReader("settings.json"))
            {
                var dbConnection = JsonSerializer.Deserialize<DbConnetion>(reader.ReadToEnd());
                _connection = new MySqlConnection($"server={dbConnection.Server};port={dbConnection.Port};username={dbConnection.UserName};password={dbConnection.Password};database={dbConnection.DataBase}");
            }
            _connection.Open(); 
        }

        public static void WriteSqlRequestToTheFile(string sqlFilePath,string outputFilePath)
        {
            var table = new DataTable();
            using (var reader = new StreamReader(sqlFilePath))
            { 
                var command = new MySqlCommand(reader.ReadToEnd(),_connection);
                var adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
            }
            using (var writer = new StreamWriter(outputFilePath))
            {
                for (var i = 0; i < table.Rows.Count; i++)
                {
                    for (var j = 0; j < table.Columns.Count; j++)
                    {
                        writer.Write(table.Rows[i][j]+"||");
                    }
                    writer.WriteLine();
                }   
            }
        }
    }
}