using TJX.VLA.Localization;
using Volo.Abp.AspNetCore.Components;

namespace TJX.VLA.Blazor;

public abstract class VLAComponentBase : AbpComponentBase
{
    protected VLAComponentBase()
    {
        LocalizationResource = typeof(VLAResource);
    }
}
