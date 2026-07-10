using IYA.Flow.Core.Entities;
using IYA.Flow.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace IYA.Flow.Web.Controllers;

public class WorkspaceController : Controller
{
    private readonly IYAFlowDbContext _context;

    public WorkspaceController(IYAFlowDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var workspaces = _context.Workspaces.ToList();

        return View(workspaces);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Workspace workspace)
    {
        if (!ModelState.IsValid)
            return View(workspace);

        _context.Workspaces.Add(workspace);

        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }
}