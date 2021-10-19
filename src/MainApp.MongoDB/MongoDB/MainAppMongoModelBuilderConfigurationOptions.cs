using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace MainApp.MongoDB
{
    public class MainAppMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public MainAppMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}