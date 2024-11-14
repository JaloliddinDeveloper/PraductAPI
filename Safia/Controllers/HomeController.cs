using Microsoft.AspNetCore.Mvc;

namespace Safia.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
