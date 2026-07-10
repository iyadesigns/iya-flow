using Microsoft.AspNetCore.Mvc;

namespace IYA.Flow.Web.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
