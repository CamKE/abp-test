using TJX.VLA.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TJX.VLA;

[DependsOn(
    typeof(VLAEntityFrameworkCoreTestModule)
    )]
public class VLADomainTestModule : AbpModule
{

}
