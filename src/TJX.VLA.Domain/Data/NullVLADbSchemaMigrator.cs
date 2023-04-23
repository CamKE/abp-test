using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TJX.VLA.Data;

/* This is used if database provider does't define
 * IVLADbSchemaMigrator implementation.
 */
public class NullVLADbSchemaMigrator : IVLADbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
