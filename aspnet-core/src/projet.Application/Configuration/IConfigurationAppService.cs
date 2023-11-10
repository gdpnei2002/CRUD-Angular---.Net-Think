using System.Threading.Tasks;
using projet.Configuration.Dto;

namespace projet.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
