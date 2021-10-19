using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MainApp.EntityFrameworkCore
{
    [ConnectionStringName(MainAppDbProperties.ConnectionStringName)]
    public interface IMainAppDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}