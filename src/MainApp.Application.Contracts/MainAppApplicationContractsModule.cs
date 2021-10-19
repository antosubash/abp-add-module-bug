using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;
using MainApp.ModuleOne;

namespace MainApp
{
    [DependsOn(
        typeof(MainAppDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    [DependsOn(typeof(ModuleOneApplicationContractsModule))]
    public class MainAppApplicationContractsModule : AbpModule
    {

    }
}
