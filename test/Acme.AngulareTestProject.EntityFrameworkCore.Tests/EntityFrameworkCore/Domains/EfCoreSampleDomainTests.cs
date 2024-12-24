using Acme.AngulareTestProject.Samples;
using Xunit;

namespace Acme.AngulareTestProject.EntityFrameworkCore.Domains;

[Collection(AngulareTestProjectTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AngulareTestProjectEntityFrameworkCoreTestModule>
{

}
