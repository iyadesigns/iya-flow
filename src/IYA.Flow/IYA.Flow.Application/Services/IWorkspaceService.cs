using IYA.Flow.Application.DTOs.Workspace;

namespace IYA.Flow.Application.Interfaces.Services;

/// <summary>
/// Defines the business operations related to Workspaces.
/// </summary>
public interface IWorkspaceService
{
    /// <summary>
    /// Gets all Workspaces.
    /// </summary>
    Task<IEnumerable<WorkspaceDto>> GetAllAsync();

    /// <summary>
    /// Gets a Workspace by its identifier.
    /// </summary>
    Task<WorkspaceDto?> GetByIdAsync(int id);

    /// <summary>
    /// Creates a new Workspace.
    /// </summary>
    Task CreateAsync(CreateWorkspaceDto dto);

    /// <summary>
    /// Updates an existing Workspace.
    /// </summary>
    Task UpdateAsync(UpdateWorkspaceDto dto);

    /// <summary>
    /// Deletes a Workspace.
    /// </summary>
    Task DeleteAsync(int id);
}