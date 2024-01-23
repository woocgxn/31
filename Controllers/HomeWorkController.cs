using Microsoft.AspNetCore.Mvc;

namespace Fuen31Site.Controllers
{
    public class HomeWorkController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
    }
}
