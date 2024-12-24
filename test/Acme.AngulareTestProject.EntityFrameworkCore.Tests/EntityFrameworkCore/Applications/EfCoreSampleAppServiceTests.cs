using Acme.AngulareTestProject.Samples;
using Xunit;

namespace Acme.AngulareTestProject.EntityFrameworkCore.Applications;

[Collection(AngulareTestProjectTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AngulareTestProjectEntityFrameworkCoreTestModule>
{

}
