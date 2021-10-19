using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace MainApp.EntityFrameworkCore
{
    public class MainAppModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public MainAppModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}