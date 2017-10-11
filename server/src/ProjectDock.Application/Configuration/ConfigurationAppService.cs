using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ProjectDock.Configuration.Dto;

namespace ProjectDock.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ProjectDockAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
