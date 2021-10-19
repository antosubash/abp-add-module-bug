using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using MainApp.ModuleOne;

namespace MainApp
{
    [DependsOn(
        typeof(MainAppApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    [DependsOn(typeof(ModuleOneHttpApiClientModule))]
    public class MainAppHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "MainApp";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(MainAppApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
