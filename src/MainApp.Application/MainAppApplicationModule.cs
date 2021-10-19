using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using MainApp.ModuleOne;

namespace MainApp
{
    [DependsOn(
        typeof(MainAppDomainModule),
        typeof(MainAppApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    [DependsOn(typeof(ModuleOneApplicationModule))]
    public class MainAppApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<MainAppApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<MainAppApplicationModule>(validate: true);
            });
        }
    }
}
