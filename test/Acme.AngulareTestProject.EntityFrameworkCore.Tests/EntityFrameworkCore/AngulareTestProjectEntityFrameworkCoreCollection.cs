using Xunit;

namespace Acme.AngulareTestProject.EntityFrameworkCore;

[CollectionDefinition(AngulareTestProjectTestConsts.CollectionDefinitionName)]
public class AngulareTestProjectEntityFrameworkCoreCollection : ICollectionFixture<AngulareTestProjectEntityFrameworkCoreFixture>
{

}
