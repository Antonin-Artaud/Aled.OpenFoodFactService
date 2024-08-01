using Aled.OpenFoodFactService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Aled.OpenFoodFactService.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class OpenFoodFactServiceController : AbpControllerBase
{
    protected OpenFoodFactServiceController()
    {
        LocalizationResource = typeof(OpenFoodFactServiceResource);
    }
}
