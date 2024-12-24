using Acme.AngulareTestProject.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Acme.AngulareTestProject.Permissions;

public class AngulareTestProjectPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AngulareTestProjectPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(AngulareTestProjectPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AngulareTestProjectResource>(name);
    }
}
