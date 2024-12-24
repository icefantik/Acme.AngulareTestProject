using Volo.Abp.Modularity;

namespace Acme.AngulareTestProject;

/* Inherit from this class for your domain layer tests. */
public abstract class AngulareTestProjectDomainTestBase<TStartupModule> : AngulareTestProjectTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
