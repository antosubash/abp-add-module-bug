using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace MainApp.ModuleOne.MongoDB
{
    public class ModuleOneMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public ModuleOneMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}