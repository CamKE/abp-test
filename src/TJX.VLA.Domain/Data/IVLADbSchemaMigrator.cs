using System.Threading.Tasks;

namespace TJX.VLA.Data;

public interface IVLADbSchemaMigrator
{
    Task MigrateAsync();
}
