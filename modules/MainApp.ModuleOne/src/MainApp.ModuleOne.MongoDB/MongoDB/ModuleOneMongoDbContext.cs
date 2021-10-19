using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace MainApp.ModuleOne.MongoDB
{
    [ConnectionStringName(ModuleOneDbProperties.ConnectionStringName)]
    public class ModuleOneMongoDbContext : AbpMongoDbContext, IModuleOneMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureModuleOne();
        }
    }
}