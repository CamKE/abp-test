using TJX.VLA.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TJX.VLA.Permissions;

public class VLAPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(VLAPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(VLAPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<VLAResource>(name);
    }
}
