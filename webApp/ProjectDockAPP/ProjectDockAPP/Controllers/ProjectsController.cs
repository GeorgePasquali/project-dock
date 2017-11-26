using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectDockAPP.data.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectDockAPP.Controllers
{   
    [Route("api/[controller]")]
    public class ProjectsController : Controller
    {
        private ProjectContext _context;

        public ProjectsController(ProjectContext projectContext)
        {
            this._context = projectContext;
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            var data = _context.Projects.ToString();
            return Ok( new{ Name= data, FavouriteColor="Blue"});
        }
    }
}
