using Microsoft.AspNetCore.Mvc;

namespace Coding_Practice.Controllers
{
    public class BeginerQuestion : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
