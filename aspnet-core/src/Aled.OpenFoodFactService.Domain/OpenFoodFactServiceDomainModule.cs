using Aled.OpenFoodFactService.MultiTenancy;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;

namespace Aled.OpenFoodFactService;

[DependsOn(
    typeof(OpenFoodFactServiceDomainSharedModule)
)]
public class OpenFoodFactServiceDomainModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Languages.Add(new LanguageInfo("en", "en", "English"));
        });

        Configure<AbpMultiTenancyOptions>(options => { options.IsEnabled = MultiTenancyConsts.IsEnabled; });
    }
}