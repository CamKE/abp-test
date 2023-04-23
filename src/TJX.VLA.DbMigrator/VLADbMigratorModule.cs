using TJX.VLA.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace TJX.VLA.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(VLAEntityFrameworkCoreModule),
    typeof(VLAApplicationContractsModule)
    )]
public class VLADbMigratorModule : AbpModule
{

}
