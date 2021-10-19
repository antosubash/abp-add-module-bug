using MainApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MainApp
{
    public abstract class MainAppController : AbpController
    {
        protected MainAppController()
        {
            LocalizationResource = typeof(MainAppResource);
        }
    }
}
