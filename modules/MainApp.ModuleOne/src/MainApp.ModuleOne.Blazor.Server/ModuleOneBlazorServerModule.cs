using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace MainApp.ModuleOne.Blazor.Server
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsServerThemingModule),
        typeof(ModuleOneBlazorModule)
        )]
    public class ModuleOneBlazorServerModule : AbpModule
    {
        
    }
}