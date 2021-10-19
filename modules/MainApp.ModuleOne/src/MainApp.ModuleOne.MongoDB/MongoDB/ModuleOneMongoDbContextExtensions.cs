using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace MainApp.ModuleOne.MongoDB
{
    public static class ModuleOneMongoDbContextExtensions
    {
        public static void ConfigureModuleOne(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new ModuleOneMongoModelBuilderConfigurationOptions(
                ModuleOneDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}