using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using projet.Configuration.Dto;

namespace projet.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : projetAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
