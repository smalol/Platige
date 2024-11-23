using Microsoft.Extensions.DependencyInjection;
using Platige.Infrastructure.Data.Configuration;

namespace Platige.Infrastructure.Data
{
    public static class DatabaseInitializer
    {
        public static void CreateDatabase(String connectionString, IServiceProvider _serviceProvider)
        {
            var connectionStringProvider = _serviceProvider.GetRequiredService<ConnectionStringProvider>();
            connectionStringProvider.SetConnectionString(connectionString);

            using (var scope = _serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                context.Database.EnsureCreated();
            }
        }
    }
}
