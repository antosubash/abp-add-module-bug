using MainApp.Localization;
using Volo.Abp.Application.Services;

namespace MainApp
{
    public abstract class MainAppAppService : ApplicationService
    {
        protected MainAppAppService()
        {
            LocalizationResource = typeof(MainAppResource);
            ObjectMapperContext = typeof(MainAppApplicationModule);
        }
    }
}
