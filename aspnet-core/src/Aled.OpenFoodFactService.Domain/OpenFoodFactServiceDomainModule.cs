using Volo.Abp.Localization;
using Volo.Abp.Modularity;

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
    }
}