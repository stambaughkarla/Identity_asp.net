using Microsoft.AspNetCore.Mvc;

namespace Stambaugh_HW_4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}