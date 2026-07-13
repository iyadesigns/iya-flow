using IYA.Flow.Application.DTOs.Workspace;
using IYA.Flow.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace IYA.Flow.Web.Controllers;

/// <summary>
/// Controller responsible for Workspace management.
/// </summary>
public class WorkspaceController : Controller
{
    /// <summary>
    /// Workspace business service.
    /// </summary>
    private readonly IWorkspaceService _workspaceService;

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkspaceController"/> class.
    /// </summary>
    /// <param name="workspaceService">Workspace service.</param>
    public WorkspaceController(IWorkspaceService workspaceService)
    {
        _workspaceService = workspaceService;
    }

    /// <summary>
    /// Displays all workspaces.
    /// </summary>
    public async Task<IActionResult> Index()
    {
        var workspaces = await _workspaceService.GetAllAsync();

        return View(workspaces);
    }

    /// <summary>
    /// Displays the create workspace form.
    /// </summary>
    [HttpGet]
    public IActionResult Create()
    {
        return View(new CreateWorkspaceDto());
    }

    /// <summary>
    /// Creates a new workspace.
    /// </summary>
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateWorkspaceDto dto)
    {
        if (!ModelState.IsValid)
            return View(dto);

        await _workspaceService.CreateAsync(dto);

        return RedirectToAction(nameof(Index));
    }

    /// <summary>
    /// Displays the edit form.
    /// </summary>
    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var dto = await _workspaceService.GetForUpdateAsync(id);

        if (dto is null)
            return NotFound();

        return View(dto);
    }

    /// <summary>
    /// Updates an existing workspace.
    /// </summary>
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateWorkspaceDto dto)
    {
        if (!ModelState.IsValid)
            return View(dto);

        await _workspaceService.UpdateAsync(dto);

        return RedirectToAction(nameof(Index));
    }

    /// <summary>
    /// Displays workspace details.
    /// </summary>
    [HttpGet]
    public async Task<IActionResult> Details(int id)
    {
        var workspace = await _workspaceService.GetByIdAsync(id);

        if (workspace is null)
            return NotFound();

        return View(workspace);
    }

    /// <summary>
    /// Displays the delete confirmation page.
    /// </summary>
    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        var workspace = await _workspaceService.GetByIdAsync(id);

        if (workspace is null)
            return NotFound();

        return View(workspace);
    }

    /// <summary>
    /// Deletes a workspace.
    /// </summary>
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _workspaceService.DeleteAsync(id);

        return RedirectToAction(nameof(Index));
    }
}