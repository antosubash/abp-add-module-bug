namespace MainApp.ModuleOne
{
    public static class ModuleOneDbProperties
    {
        public static string DbTablePrefix { get; set; } = "ModuleOne";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "ModuleOne";
    }
}
