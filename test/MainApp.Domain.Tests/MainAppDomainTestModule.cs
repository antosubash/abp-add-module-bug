using MainApp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MainApp
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(MainAppEntityFrameworkCoreTestModule)
        )]
    public class MainAppDomainTestModule : AbpModule
    {
        
    }
}
