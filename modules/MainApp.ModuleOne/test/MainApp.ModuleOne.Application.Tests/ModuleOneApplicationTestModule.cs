using Volo.Abp.Modularity;

namespace MainApp.ModuleOne
{
    [DependsOn(
        typeof(ModuleOneApplicationModule),
        typeof(ModuleOneDomainTestModule)
        )]
    public class ModuleOneApplicationTestModule : AbpModule
    {

    }
}
