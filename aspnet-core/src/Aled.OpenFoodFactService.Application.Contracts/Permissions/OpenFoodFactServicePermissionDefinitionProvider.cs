using Aled.OpenFoodFactService.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Aled.OpenFoodFactService.Permissions;

public class OpenFoodFactServicePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(OpenFoodFactServicePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(OpenFoodFactServicePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<OpenFoodFactServiceResource>(name);
    }
}
