using Microsoft.AspNetCore.Mvc;

namespace IYA.Flow.Web.Controllers
{
    public class WorkspaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
