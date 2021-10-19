using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace MainApp.ModuleOne.MongoDB
{
    [ConnectionStringName(ModuleOneDbProperties.ConnectionStringName)]
    public interface IModuleOneMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
