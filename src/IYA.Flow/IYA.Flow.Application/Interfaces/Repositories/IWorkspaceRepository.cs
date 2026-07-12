using IYA.Flow.Core.Entities;

namespace IYA.Flow.Application.Interfaces.Repositories;

public interface IWorkspaceRepository
{
    Task<IEnumerable<Workspace>> GetAllAsync();

    Task<Workspace?> GetByIdAsync(int id);

    Task AddAsync(Workspace workspace);

    Task UpdateAsync(Workspace workspace);

    Task DeleteAsync(int id);

    Task SaveChangesAsync();
}