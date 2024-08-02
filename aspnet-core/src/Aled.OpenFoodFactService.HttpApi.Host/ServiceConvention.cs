using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.Extensions.Options;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.ApiExploring;
using Volo.Abp.AspNetCore.Mvc.Conventions;
using Volo.Abp.DependencyInjection;

namespace Aled.OpenFoodFactService;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IAbpServiceConvention))]
public class ServiceConvention(
    IOptions<AbpAspNetCoreMvcOptions> options,
    IConventionalRouteBuilder conventionalRouteBuilder)
    : AbpServiceConvention(options, conventionalRouteBuilder)
{
    protected override void ApplyForControllers(ApplicationModel application)
    {
        application.Controllers.RemoveAll(s => s.ControllerType != typeof(AbpApiDefinitionController)
                                               && s.ControllerType.Namespace?.StartsWith("Aled.OpenFoodFactService") ==
                                               false);

        base.ApplyForControllers(application);
    }
}