using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace MainApp.ModuleOne.Blazor.Menus
{
    public class ModuleOneMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            //Add main menu items.
            context.Menu.AddItem(new ApplicationMenuItem(ModuleOneMenus.Prefix, displayName: "ModuleOne", "/ModuleOne", icon: "fa fa-globe"));
            
            return Task.CompletedTask;
        }
    }
}