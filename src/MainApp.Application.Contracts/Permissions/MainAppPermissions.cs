using Volo.Abp.Reflection;

namespace MainApp.Permissions
{
    public class MainAppPermissions
    {
        public const string GroupName = "MainApp";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(MainAppPermissions));
        }
    }
}