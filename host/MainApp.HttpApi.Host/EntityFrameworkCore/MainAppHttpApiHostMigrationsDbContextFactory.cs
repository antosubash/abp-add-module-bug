using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MainApp.EntityFrameworkCore
{
    public class MainAppHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<MainAppHttpApiHostMigrationsDbContext>
    {
        public MainAppHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<MainAppHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("MainApp"));

            return new MainAppHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
