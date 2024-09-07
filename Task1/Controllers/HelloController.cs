using Microsoft.AspNetCore.Mvc;

namespace Task1.Controllers
{
    public class HelloController : Controller
    {
        public string Index()
        {
            return "Hello World";
        }

        public IActionResult Hello()
        {
            return View();
        }
    }
}
