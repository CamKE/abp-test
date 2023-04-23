using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TJX.VLA;

[Dependency(ReplaceServices = true)]
public class VLABrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "VLA";
}
