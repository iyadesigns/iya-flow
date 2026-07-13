using AutoMapper;
using IYA.Flow.Application.DTOs.Workspace;
using IYA.Flow.Core.Entities;

namespace IYA.Flow.Application.Mappings;

/// <summary>
/// AutoMapper profile responsible for Workspace mappings.
/// </summary>
public class WorkspaceProfile : Profile
{
    /// <summary>
    /// Configures all Workspace mappings.
    /// </summary>
    public WorkspaceProfile()
    {
        // DTO -> Entity
        CreateMap<CreateWorkspaceDto, Workspace>();

        CreateMap<UpdateWorkspaceDto, Workspace>();

        CreateMap<Workspace, UpdateWorkspaceDto>();

        // Entity -> DTO
        CreateMap<Workspace, WorkspaceDto>();
    }
}