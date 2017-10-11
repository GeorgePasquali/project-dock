using System.Threading.Tasks;
using ProjectDock.Configuration.Dto;

namespace ProjectDock.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}