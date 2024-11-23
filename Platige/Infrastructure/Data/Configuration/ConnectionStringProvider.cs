namespace Platige.Infrastructure.Data.Configuration
{
    public class ConnectionStringProvider
    {
        public string? ConnectionString { get; private set; }

        public void SetConnectionString(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
