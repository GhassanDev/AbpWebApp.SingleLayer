using Microsoft.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;

namespace WebApp.SingleLayer.Data;

public class SingleLayerEFCoreDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public SingleLayerEFCoreDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the SingleLayerDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SingleLayerDbContext>()
            .Database
            .MigrateAsync();
    }
}
