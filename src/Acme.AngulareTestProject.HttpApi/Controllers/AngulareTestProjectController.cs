using Acme.AngulareTestProject.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.AngulareTestProject.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AngulareTestProjectController : AbpControllerBase
{
    protected AngulareTestProjectController()
    {
        LocalizationResource = typeof(AngulareTestProjectResource);
    }
}
