using Microsoft.AspNetCore.Mvc;

namespace IYA.Flow.Web.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
