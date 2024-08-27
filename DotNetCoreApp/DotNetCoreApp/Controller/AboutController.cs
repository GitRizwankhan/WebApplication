using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreApp.Controller
{
    public class AboutController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }

        private IActionResult View()
        {
            throw new NotImplementedException();
        }
    }
}
