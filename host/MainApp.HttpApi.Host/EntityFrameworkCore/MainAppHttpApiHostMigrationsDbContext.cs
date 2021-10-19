using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace MainApp.EntityFrameworkCore
{
    public class MainAppHttpApiHostMigrationsDbContext : AbpDbContext<MainAppHttpApiHostMigrationsDbContext>
    {
        public MainAppHttpApiHostMigrationsDbContext(DbContextOptions<MainAppHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureMainApp();
        }
    }
}
