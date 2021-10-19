using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MainApp.ModuleOne.EntityFrameworkCore
{
    [ConnectionStringName(ModuleOneDbProperties.ConnectionStringName)]
    public interface IModuleOneDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}