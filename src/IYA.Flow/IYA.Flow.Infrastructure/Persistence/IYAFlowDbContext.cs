using IYA.Flow.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace IYA.Flow.Infrastructure.Persistence;

public class IYAFlowDbContext : DbContext
{
    public IYAFlowDbContext(DbContextOptions<IYAFlowDbContext> options)
        : base(options)
    {
    }

    public DbSet<Workspace> Workspaces => Set<Workspace>();
}