using System.Threading.Tasks;
using Abp.Application.Services;
using ProjectDock.Sessions.Dto;

namespace ProjectDock.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
