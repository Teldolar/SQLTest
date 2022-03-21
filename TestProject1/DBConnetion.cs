using System.Text.Json.Serialization;

namespace TestProject1
{
    public class DbConnetion
    {
        [JsonPropertyName("server")] 
        public string Server { get; set; }
        [JsonPropertyName("port")] 
        public int Port { get; set; }
        [JsonPropertyName("username")] 
        public string UserName { get; set; }
        [JsonPropertyName("password")] 
        public string Password { get; set; }
        [JsonPropertyName("database")] 
        public string DataBase { get; set; }
    }
}