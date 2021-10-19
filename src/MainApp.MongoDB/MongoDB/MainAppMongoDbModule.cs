using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;
using MainApp.ModuleOne.MongoDB;

namespace MainApp.MongoDB
{
    [DependsOn(
        typeof(MainAppDomainModule),
        typeof(AbpMongoDbModule)
        )]
    [DependsOn(typeof(ModuleOneMongoDbModule))]
    public class MainAppMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<MainAppMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}
