using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using MainApp.ModuleOne;

namespace MainApp
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(MainAppDomainSharedModule)
    )]
    [DependsOn(typeof(ModuleOneDomainModule))]
    public class MainAppDomainModule : AbpModule
    {

    }
}
