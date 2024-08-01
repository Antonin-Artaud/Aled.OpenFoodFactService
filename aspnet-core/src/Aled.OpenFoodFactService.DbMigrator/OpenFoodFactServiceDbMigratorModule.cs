using Aled.OpenFoodFactService.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.Caching;
using Volo.Abp.Caching.StackExchangeRedis;
using Volo.Abp.Modularity;

namespace Aled.OpenFoodFactService.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpCachingStackExchangeRedisModule),
    typeof(OpenFoodFactServiceMongoDbModule),
    typeof(OpenFoodFactServiceApplicationContractsModule)
    )]
public class OpenFoodFactServiceDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDistributedCacheOptions>(options => { options.KeyPrefix = "OpenFoodFactService:"; });
    }
}
