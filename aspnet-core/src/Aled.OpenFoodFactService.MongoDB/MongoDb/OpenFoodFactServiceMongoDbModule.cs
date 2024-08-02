using Aled.OpenFoodFactService.Entities.Products;
using Aled.OpenFoodFactService.Repositories.Products;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AuditLogging.MongoDB;
using Volo.Abp.BackgroundJobs.MongoDB;
using Volo.Abp.FeatureManagement.MongoDB;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.MongoDB;
using Volo.Abp.SettingManagement.MongoDB;
using Volo.Abp.Uow;

namespace Aled.OpenFoodFactService.MongoDB;

[DependsOn(
    typeof(OpenFoodFactServiceDomainModule),
    typeof(AbpPermissionManagementMongoDbModule),
    typeof(AbpSettingManagementMongoDbModule),
    typeof(AbpBackgroundJobsMongoDbModule),
    typeof(AbpAuditLoggingMongoDbModule),
    typeof(AbpFeatureManagementMongoDbModule)
)]
public class OpenFoodFactServiceMongoDbModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddMongoDbContext<OpenFoodFactServiceMongoDbContext>(options =>
        {
            options.AddDefaultRepositories();
            options.AddRepository<Product, MongoDbProductRepository>();
        });

        Configure<AbpUnitOfWorkDefaultOptions>(options =>
        {
            options.TransactionBehavior = UnitOfWorkTransactionBehavior.Disabled;
        });
    }
}