using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TJX.VLA.Data;
using Volo.Abp.DependencyInjection;

namespace TJX.VLA.EntityFrameworkCore;

public class EntityFrameworkCoreVLADbSchemaMigrator
    : IVLADbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreVLADbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the VLADbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<VLADbContext>()
            .Database
            .MigrateAsync();
    }
}
