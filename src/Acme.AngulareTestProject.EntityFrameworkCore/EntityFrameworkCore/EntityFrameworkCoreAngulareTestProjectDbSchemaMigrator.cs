using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.AngulareTestProject.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.AngulareTestProject.EntityFrameworkCore;

public class EntityFrameworkCoreAngulareTestProjectDbSchemaMigrator
    : IAngulareTestProjectDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAngulareTestProjectDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AngulareTestProjectDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AngulareTestProjectDbContext>()
            .Database
            .MigrateAsync();
    }
}
