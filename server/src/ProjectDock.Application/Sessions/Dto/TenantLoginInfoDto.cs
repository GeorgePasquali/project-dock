using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ProjectDock.MultiTenancy;

namespace ProjectDock.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}