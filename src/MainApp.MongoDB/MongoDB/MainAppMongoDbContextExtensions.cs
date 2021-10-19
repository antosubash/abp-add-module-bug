using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace MainApp.MongoDB
{
    public static class MainAppMongoDbContextExtensions
    {
        public static void ConfigureMainApp(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new MainAppMongoModelBuilderConfigurationOptions(
                MainAppDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}