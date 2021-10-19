using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MainApp.ModuleOne.EntityFrameworkCore
{
    [DependsOn(
        typeof(ModuleOneDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class ModuleOneEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ModuleOneDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
            });
        }
    }
}