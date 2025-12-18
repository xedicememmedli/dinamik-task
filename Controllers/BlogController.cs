using Microsoft.AspNetCore.Mvc;

namespace front_to_back_code.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
