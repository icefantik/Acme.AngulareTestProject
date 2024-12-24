using Volo.Abp.Modularity;

namespace Acme.AngulareTestProject;

[DependsOn(
    typeof(AngulareTestProjectApplicationModule),
    typeof(AngulareTestProjectDomainTestModule)
)]
public class AngulareTestProjectApplicationTestModule : AbpModule
{

}
