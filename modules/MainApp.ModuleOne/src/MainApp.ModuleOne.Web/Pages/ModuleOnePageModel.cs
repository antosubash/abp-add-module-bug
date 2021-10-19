using MainApp.ModuleOne.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MainApp.ModuleOne.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class ModuleOnePageModel : AbpPageModel
    {
        protected ModuleOnePageModel()
        {
            LocalizationResourceType = typeof(ModuleOneResource);
            ObjectMapperContext = typeof(ModuleOneWebModule);
        }
    }
}