using System;
using System.Collections.Generic;
using System.Text;
using TJX.VLA.Localization;
using Volo.Abp.Application.Services;

namespace TJX.VLA;

/* Inherit your application services from this class.
 */
public abstract class VLAAppService : ApplicationService
{
    protected VLAAppService()
    {
        LocalizationResource = typeof(VLAResource);
    }
}
