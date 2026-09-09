using Microsoft.AspNetCore.Mvc;

namespace W02.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}