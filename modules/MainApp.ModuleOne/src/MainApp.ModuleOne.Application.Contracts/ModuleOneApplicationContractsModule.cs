using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace MainApp.ModuleOne
{
    [DependsOn(
        typeof(ModuleOneDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class ModuleOneApplicationContractsModule : AbpModule
    {

    }
}
