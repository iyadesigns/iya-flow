using IYA.Flow.Application.DTOs.Workspace;
using IYA.Flow.Application.Interfaces.Services;
using IYA.Flow.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace IYA.Flow.Web.Controllers;

/// <summary>
/// Controller responsible for managing Workspace operations.
/// Handles requests related to listing and creating workspaces.
/// </summary>
public class WorkspaceController : Controller
{
    /// <summary>
    /// Service that encapsulates the business logic for Workspaces.
    /// </summary>
    private readonly IWorkspaceService _workspaceService;

    /// <summary>
    /// Constructor with Dependency Injection.
    /// </summary>
    /// <param name="workspaceService">Workspace service instance.</param>
    public WorkspaceController(IWorkspaceService workspaceService)
    {
        _workspaceService = workspaceService;
    }

    /// <summary>
    /// Displays the list of all available workspaces.
    /// </summary>
    /// <returns>Workspace list view.</returns>
    public async Task<IActionResult> Index()
    {
        var workspaces = await _workspaceService.GetAllAsync();

        return View(workspaces);
    }

    /// <summary>
    /// Displays the form to create a new Workspace.
    /// </summary>
    /// <returns>Create Workspace view.</returns>
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    /// <summary>
    /// Creates a new Workspace.
    /// </summary>
    /// <param name="workspace">Workspace data submitted by the user.</param>
    /// <returns>Redirects to the Workspace list if successful.</returns>
    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public async Task<IActionResult> Create(Workspace workspace)
    //{
    //    // Validate the submitted model.
    //    if (!ModelState.IsValid)
    //        return View(workspace);

    //    // Delegate the creation process to the Service layer.
    //    await _workspaceService.CreateAsync(workspace);

    //    // Redirect to the Workspace list.
    //    return RedirectToAction(nameof(Index));
    //}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateWorkspaceDto dto)
    {
        if (!ModelState.IsValid)
            return View(dto);

        await _workspaceService.CreateAsync(dto);

        return RedirectToAction(nameof(Index));
    }
}