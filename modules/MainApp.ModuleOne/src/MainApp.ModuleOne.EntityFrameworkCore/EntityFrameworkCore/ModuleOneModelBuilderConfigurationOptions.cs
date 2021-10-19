using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace MainApp.ModuleOne.EntityFrameworkCore
{
    public class ModuleOneModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public ModuleOneModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}