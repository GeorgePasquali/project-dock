using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectDockAPP.data.Models
{
    public class ProjectContext : DbContext
    {

        public ProjectContext()
        {

        }

        public DbSet<Projects> Projects { get; set;}
    }
}
