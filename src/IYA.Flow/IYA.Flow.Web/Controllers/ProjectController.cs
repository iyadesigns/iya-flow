using Microsoft.AspNetCore.Mvc;

namespace IYA.Flow.Web.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
