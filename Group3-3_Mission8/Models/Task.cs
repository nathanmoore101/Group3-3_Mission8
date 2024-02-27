using Microsoft.AspNetCore.Mvc;

namespace Group3_3_Mission8.Models
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
