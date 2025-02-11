namespace TaskManager.API.Data.Configurations
{
    public class DatabaseConfig : IDatabaseConfig
    {
        public string DatabaseName { get;  set; }
        public string ConnectionString { get; set; }
        public DatabaseConfig()
        {
            DatabaseName = "taskManager";
            ConnectionString = "mongodb://localhost:27017";
        }
    }
}
