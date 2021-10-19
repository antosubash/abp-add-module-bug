using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace MainApp.ModuleOne
{
    [DependsOn(
        typeof(ModuleOneHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ModuleOneConsoleApiClientModule : AbpModule
    {
        
    }
}
