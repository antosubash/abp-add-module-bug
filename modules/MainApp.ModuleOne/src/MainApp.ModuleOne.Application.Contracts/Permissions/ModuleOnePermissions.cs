using Volo.Abp.Reflection;

namespace MainApp.ModuleOne.Permissions
{
    public class ModuleOnePermissions
    {
        public const string GroupName = "ModuleOne";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(ModuleOnePermissions));
        }
    }
}