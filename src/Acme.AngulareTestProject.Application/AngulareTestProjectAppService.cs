using Acme.AngulareTestProject.Localization;
using Volo.Abp.Application.Services;

namespace Acme.AngulareTestProject;

/* Inherit your application services from this class.
 */
public abstract class AngulareTestProjectAppService : ApplicationService
{
    protected AngulareTestProjectAppService()
    {
        LocalizationResource = typeof(AngulareTestProjectResource);
    }
}
