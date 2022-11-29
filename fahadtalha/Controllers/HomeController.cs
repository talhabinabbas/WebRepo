using Microsoft.AspNetCore.Mvc;

namespace fahadtalha.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
