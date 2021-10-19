using MainApp.Localization;
using Volo.Abp.AspNetCore.Components;

namespace MainApp.Blazor.Server.Host
{
    public abstract class MainAppComponentBase : AbpComponentBase
    {
        protected MainAppComponentBase()
        {
            LocalizationResource = typeof(MainAppResource);
        }
    }
}
