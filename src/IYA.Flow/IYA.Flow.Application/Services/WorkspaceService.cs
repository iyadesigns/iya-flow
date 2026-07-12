using AutoMapper;
using IYA.Flow.Application.DTOs.Workspace;
using IYA.Flow.Application.Interfaces.Repositories;
using IYA.Flow.Application.Interfaces.Services;
using IYA.Flow.Core.Entities;

namespace IYA.Flow.Application.Services;

/// <summary>
/// Provides business logic for Workspace management.
/// </summary>
public class WorkspaceService : IWorkspaceService
{
    /// <summary>
    /// Repository used to access Workspace data.
    /// </summary>
    private readonly IWorkspaceRepository _repository;

    /// <summary>
    /// AutoMapper instance used to map DTOs and entities.
    /// </summary>
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkspaceService"/> class.
    /// </summary>
    /// <param name="repository">Workspace repository.</param>
    /// <param name="mapper">AutoMapper instance.</param>
    public WorkspaceService(
        IWorkspaceRepository repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    /// <summary>
    /// Retrieves all workspaces.
    /// </summary>
    /// <returns>A collection of <see cref="WorkspaceDto"/>.</returns>
    public async Task<IEnumerable<WorkspaceDto>> GetAllAsync()
    {
        var workspaces = await _repository.GetAllAsync();

        return _mapper.Map<IEnumerable<WorkspaceDto>>(workspaces);
    }

    /// <summary>
    /// Retrieves a workspace by its identifier.
    /// </summary>
    /// <param name="id">Workspace identifier.</param>
    /// <returns>The workspace if found; otherwise null.</returns>
    public async Task<WorkspaceDto?> GetByIdAsync(int id)
    {
        var workspace = await _repository.GetByIdAsync(id);

        if (workspace is null)
            return null;

        return _mapper.Map<WorkspaceDto>(workspace);
    }

    /// <summary>
    /// Creates a new workspace.
    /// </summary>
    /// <param name="dto">Workspace creation data.</param>
    public async Task CreateAsync(CreateWorkspaceDto dto)
    {
        var workspace = _mapper.Map<Workspace>(dto);

        await _repository.AddAsync(workspace);
        await _repository.SaveChangesAsync();
    }

    /// <summary>
    /// Updates an existing workspace.
    /// </summary>
    /// <param name="dto">Workspace update data.</param>
    public async Task UpdateAsync(UpdateWorkspaceDto dto)
    {
        var workspace = _mapper.Map<Workspace>(dto);

        await _repository.UpdateAsync(workspace);
        await _repository.SaveChangesAsync();
    }

    /// <summary>
    /// Deletes a workspace.
    /// </summary>
    /// <param name="id">Workspace identifier.</param>
    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
        await _repository.SaveChangesAsync();
    }
}