using Microsoft.AspNetCore.Mvc;

namespace ProjectFinal.Area.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/home")]
    [Route("admin")]
    public class HomeController : Controller
    {
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
