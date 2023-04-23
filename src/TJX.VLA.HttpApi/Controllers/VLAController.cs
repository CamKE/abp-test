using TJX.VLA.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TJX.VLA.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class VLAController : AbpControllerBase
{
    protected VLAController()
    {
        LocalizationResource = typeof(VLAResource);
    }
}
