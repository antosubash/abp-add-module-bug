using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace MainApp.MongoDB
{
    [ConnectionStringName(MainAppDbProperties.ConnectionStringName)]
    public class MainAppMongoDbContext : AbpMongoDbContext, IMainAppMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureMainApp();
        }
    }
}