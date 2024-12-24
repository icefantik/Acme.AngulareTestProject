using Acme.AngulareTestProject.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.AngulareTestProject.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AngulareTestProjectEntityFrameworkCoreModule),
    typeof(AngulareTestProjectApplicationContractsModule)
)]
public class AngulareTestProjectDbMigratorModule : AbpModule
{
}
