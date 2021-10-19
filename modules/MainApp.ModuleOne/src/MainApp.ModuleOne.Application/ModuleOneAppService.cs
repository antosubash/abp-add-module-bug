using MainApp.ModuleOne.Localization;
using Volo.Abp.Application.Services;

namespace MainApp.ModuleOne
{
    public abstract class ModuleOneAppService : ApplicationService
    {
        protected ModuleOneAppService()
        {
            LocalizationResource = typeof(ModuleOneResource);
            ObjectMapperContext = typeof(ModuleOneApplicationModule);
        }
    }
}
