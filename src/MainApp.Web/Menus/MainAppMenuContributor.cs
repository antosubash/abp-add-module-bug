using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace MainApp.Web.Menus
{
    public class MainAppMenuContributor : IMenuContributor
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
            context.Menu.AddItem(new ApplicationMenuItem(MainAppMenus.Prefix, displayName: "MainApp", "~/MainApp", icon: "fa fa-globe"));

            return Task.CompletedTask;
        }
    }
}