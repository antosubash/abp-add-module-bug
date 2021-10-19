using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace MainApp.Blazor.WebAssembly
{
    [DependsOn(
        typeof(MainAppBlazorModule),
        typeof(MainAppHttpApiClientModule),
        typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
        )]
    public class MainAppBlazorWebAssemblyModule : AbpModule
    {
        
    }
}