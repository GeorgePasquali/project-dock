using Abp.Zero.EntityFrameworkCore;
using ProjectDock.Authorization.Roles;
using ProjectDock.Authorization.Users;
using ProjectDock.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace ProjectDock.EntityFrameworkCore
{
    public class ProjectDockDbContext : AbpZeroDbContext<Tenant, Role, User, ProjectDockDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public ProjectDockDbContext(DbContextOptions<ProjectDockDbContext> options)
            : base(options)
        {

        }
    }
}
