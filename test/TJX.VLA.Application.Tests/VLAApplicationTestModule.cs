using Volo.Abp.Modularity;

namespace TJX.VLA;

[DependsOn(
    typeof(VLAApplicationModule),
    typeof(VLADomainTestModule)
    )]
public class VLAApplicationTestModule : AbpModule
{

}
