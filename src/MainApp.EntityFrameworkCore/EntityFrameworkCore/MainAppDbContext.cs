using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using MainApp.ModuleOne.EntityFrameworkCore;

namespace MainApp.EntityFrameworkCore
{
    [ConnectionStringName(MainAppDbProperties.ConnectionStringName)]
    public class MainAppDbContext : AbpDbContext<MainAppDbContext>, IMainAppDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public MainAppDbContext(DbContextOptions<MainAppDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureMainApp();
            builder.ConfigureModuleOne();
        }
    }
}