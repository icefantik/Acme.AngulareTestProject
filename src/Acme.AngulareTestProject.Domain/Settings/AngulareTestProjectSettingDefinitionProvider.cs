using Volo.Abp.Settings;

namespace Acme.AngulareTestProject.Settings;

public class AngulareTestProjectSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AngulareTestProjectSettings.MySetting1));
    }
}
