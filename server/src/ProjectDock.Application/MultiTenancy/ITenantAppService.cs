using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ProjectDock.MultiTenancy.Dto;

namespace ProjectDock.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
