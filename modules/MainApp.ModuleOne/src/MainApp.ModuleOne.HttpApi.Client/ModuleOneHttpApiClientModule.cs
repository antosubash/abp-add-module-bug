using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace MainApp.ModuleOne
{
    [DependsOn(
        typeof(ModuleOneApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class ModuleOneHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "ModuleOne";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(ModuleOneApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
