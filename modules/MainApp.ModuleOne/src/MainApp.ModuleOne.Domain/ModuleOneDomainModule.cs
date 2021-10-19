using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace MainApp.ModuleOne
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(ModuleOneDomainSharedModule)
    )]
    public class ModuleOneDomainModule : AbpModule
    {

    }
}
