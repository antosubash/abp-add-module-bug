using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace MainApp
{
    [DependsOn(
        typeof(MainAppHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class MainAppConsoleApiClientModule : AbpModule
    {
        
    }
}
