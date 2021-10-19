using Localization.Resources.AbpUi;
using MainApp.ModuleOne.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace MainApp.ModuleOne
{
    [DependsOn(
        typeof(ModuleOneApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class ModuleOneHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(ModuleOneHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<ModuleOneResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
