using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectDock.Models;

namespace ProjectDock.Controllers
{
    [Produces("application/json")]
    [Route("api/Projects")]
    public class ProjectsController : Controller
    {
        // private readonly
        
        static List<Project> projects = new List<Project>{
                new Project
                {
                    Name = "GitHub",
                    Description = "The Sourse storage website."
                },
                new Project
                {
                    Name = "Electron",
                    Description = "Cross platform for web applications..."
                }

            };
        
        //readonly ApiContext context;
        /*
        public ProjectsController( ApiContext context )
        {
            this.context = context;
        }
        */
        [HttpGet]
        public IEnumerable<Project> Get()
        {
            return projects;
            
        }
        
        [HttpGet("{name}")]
        public IEnumerable<Project> Get(string name)
        {
            return projects.FindAll(projects => projects.Name == name);

        }

        [HttpPost]
        public Project Post([FromBody] Project project)
        {
            projects.Add(project);
            return project;
        }

        
    }
}