using Volo.Abp.Settings;

namespace TJX.VLA.Settings;

public class VLASettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(VLASettings.MySetting1));
    }
}
