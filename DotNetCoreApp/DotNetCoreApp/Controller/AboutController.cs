using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreApp.Controller
{
    public class AboutController : ControllerBase
    {
        public IActionResult Index()
        {
            string dd = "";
            return View();
        }

        private IActionResult View()
        {
            throw new NotImplementedException();
        }
    }
}
