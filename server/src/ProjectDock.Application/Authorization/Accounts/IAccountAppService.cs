using System.Threading.Tasks;
using Abp.Application.Services;
using ProjectDock.Authorization.Accounts.Dto;

namespace ProjectDock.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
