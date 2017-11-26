using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectDockAPP.Entities;

namespace ProjectDockAPP.data.Models
{
    public class ProjectContext : DbContext
    {
        
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().ToTable("Projects");
        }

        public DbSet<Project> Projects { get; set;}
    }
}
