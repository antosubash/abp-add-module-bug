using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using MainApp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;
using MainApp.ModuleOne;

namespace MainApp
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    [DependsOn(typeof(ModuleOneDomainSharedModule))]
    public class MainAppDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<MainAppDomainSharedModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<MainAppResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/MainApp");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("MainApp", typeof(MainAppResource));
            });
        }
    }
}
