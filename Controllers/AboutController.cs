using Microsoft.AspNetCore.Mvc;

namespace escale.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
