using IYA.Flow.Infrastructure.Persistence;
using IYA.Flow.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace IYA.Flow.Web.Controllers;

public class DashboardController : Controller
{
    private readonly IYAFlowDbContext _context;

    public DashboardController(IYAFlowDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Dashboard home page.
    /// </summary>
    public IActionResult Index()
    {
        var model = new DashboardViewModel
        {
            TotalWorkspaces = _context.Workspaces.Count(),

            // Se completarán cuando existan
            TotalProjects = 0,
            TotalTasks = 0,
            TotalNotes = 0
        };

        return View(model);
    }
}