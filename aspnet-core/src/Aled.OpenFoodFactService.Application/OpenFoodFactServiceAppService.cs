using System;
using System.Collections.Generic;
using System.Text;
using Aled.OpenFoodFactService.Localization;
using Volo.Abp.Application.Services;

namespace Aled.OpenFoodFactService;

/* Inherit your application services from this class.
 */
public abstract class OpenFoodFactServiceAppService : ApplicationService
{
    protected OpenFoodFactServiceAppService()
    {
        LocalizationResource = typeof(OpenFoodFactServiceResource);
    }
}
