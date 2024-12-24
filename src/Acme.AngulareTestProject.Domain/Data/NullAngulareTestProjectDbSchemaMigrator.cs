using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.AngulareTestProject.Data;

/* This is used if database provider does't define
 * IAngulareTestProjectDbSchemaMigrator implementation.
 */
public class NullAngulareTestProjectDbSchemaMigrator : IAngulareTestProjectDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
