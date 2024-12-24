using Microsoft.Extensions.Localization;
using Acme.AngulareTestProject.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Acme.AngulareTestProject;

[Dependency(ReplaceServices = true)]
public class AngulareTestProjectBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<AngulareTestProjectResource> _localizer;

    public AngulareTestProjectBrandingProvider(IStringLocalizer<AngulareTestProjectResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
