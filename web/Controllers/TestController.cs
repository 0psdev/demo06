using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
