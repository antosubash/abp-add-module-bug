using MainApp.ModuleOne.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MainApp.ModuleOne.Permissions
{
    public class ModuleOnePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ModuleOnePermissions.GroupName, L("Permission:ModuleOne"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ModuleOneResource>(name);
        }
    }
}