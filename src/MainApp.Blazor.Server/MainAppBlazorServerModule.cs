using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace MainApp.Blazor.Server
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsServerThemingModule),
        typeof(MainAppBlazorModule)
        )]
    public class MainAppBlazorServerModule : AbpModule
    {
        
    }
}