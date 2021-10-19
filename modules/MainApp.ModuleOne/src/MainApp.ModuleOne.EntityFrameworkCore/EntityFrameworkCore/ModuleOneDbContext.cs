using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MainApp.ModuleOne.EntityFrameworkCore
{
    [ConnectionStringName(ModuleOneDbProperties.ConnectionStringName)]
    public class ModuleOneDbContext : AbpDbContext<ModuleOneDbContext>, IModuleOneDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public ModuleOneDbContext(DbContextOptions<ModuleOneDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureModuleOne();
        }
    }
}