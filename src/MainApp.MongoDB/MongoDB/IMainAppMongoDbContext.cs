using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace MainApp.MongoDB
{
    [ConnectionStringName(MainAppDbProperties.ConnectionStringName)]
    public interface IMainAppMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
