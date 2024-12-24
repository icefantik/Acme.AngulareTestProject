using System.Threading.Tasks;

namespace Acme.AngulareTestProject.Data;

public interface IAngulareTestProjectDbSchemaMigrator
{
    Task MigrateAsync();
}
