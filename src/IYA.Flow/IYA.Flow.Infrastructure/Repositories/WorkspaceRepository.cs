using IYA.Flow.Application.Interfaces.Repositories;
using IYA.Flow.Core.Entities;
using IYA.Flow.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IYA.Flow.Infrastructure.Repositories;

public class WorkspaceRepository : IWorkspaceRepository
{
    private readonly IYAFlowDbContext _context;

    public WorkspaceRepository(IYAFlowDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Workspace>> GetAllAsync()
    {
        return await _context.Workspaces.ToListAsync();
    }

    public async Task<Workspace?> GetByIdAsync(int id)
    {
        return await _context.Workspaces.FindAsync(id);
    }

    public async Task AddAsync(Workspace workspace)
    {
        await _context.Workspaces.AddAsync(workspace);
    }

    public async Task UpdateAsync(Workspace workspace)
    {
        _context.Workspaces.Update(workspace);
    }

    public async Task DeleteAsync(int id)
    {
        var workspace = await GetByIdAsync(id);

        if (workspace != null)
            _context.Workspaces.Remove(workspace);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}