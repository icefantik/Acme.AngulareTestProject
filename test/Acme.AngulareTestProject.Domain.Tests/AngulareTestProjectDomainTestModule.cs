using Volo.Abp.Modularity;

namespace Acme.AngulareTestProject;

[DependsOn(
    typeof(AngulareTestProjectDomainModule),
    typeof(AngulareTestProjectTestBaseModule)
)]
public class AngulareTestProjectDomainTestModule : AbpModule
{

}
