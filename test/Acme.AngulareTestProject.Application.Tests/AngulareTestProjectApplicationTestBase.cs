using Volo.Abp.Modularity;

namespace Acme.AngulareTestProject;

public abstract class AngulareTestProjectApplicationTestBase<TStartupModule> : AngulareTestProjectTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
