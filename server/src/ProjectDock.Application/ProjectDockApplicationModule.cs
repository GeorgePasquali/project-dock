using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProjectDock.Authorization;

namespace ProjectDock
{
    [DependsOn(
        typeof(ProjectDockCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ProjectDockApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ProjectDockAuthorizationProvider>();
        }

        public override void Initialize()
        {
            Assembly thisAssembly = typeof(ProjectDockApplicationModule).GetAssembly();
            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                //Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
        }
    }
}