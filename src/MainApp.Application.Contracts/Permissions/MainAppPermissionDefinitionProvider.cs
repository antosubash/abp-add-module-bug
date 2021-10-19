using MainApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MainApp.Permissions
{
    public class MainAppPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(MainAppPermissions.GroupName, L("Permission:MainApp"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MainAppResource>(name);
        }
    }
}