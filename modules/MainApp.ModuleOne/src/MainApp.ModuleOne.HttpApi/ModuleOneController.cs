using MainApp.ModuleOne.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MainApp.ModuleOne
{
    public abstract class ModuleOneController : AbpController
    {
        protected ModuleOneController()
        {
            LocalizationResource = typeof(ModuleOneResource);
        }
    }
}
