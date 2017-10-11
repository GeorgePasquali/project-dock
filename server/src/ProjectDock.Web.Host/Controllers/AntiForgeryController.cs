using ProjectDock.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace ProjectDock.Web.Host.Controllers
{
    public class AntiForgeryController : ProjectDockControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}