using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MainApp.Blazor.Server.Host
{
    [Dependency(ReplaceServices = true)]
    public class MainAppBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "MainApp";
    }
}
