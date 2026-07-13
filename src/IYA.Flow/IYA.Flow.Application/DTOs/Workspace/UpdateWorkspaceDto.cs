using System.ComponentModel.DataAnnotations;
using IYA.Flow.Core.Constants;

namespace IYA.Flow.Application.DTOs.Workspace;

/// <summary>
/// DTO used to update an existing Workspace.
/// </summary>
public class UpdateWorkspaceDto
{
    /// <summary>
    /// Workspace identifier.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Workspace name.
    /// </summary>
    [Required(ErrorMessage = "Workspace name is required.")]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Workspace description.
    /// </summary>
    [StringLength(500)]
    public string? Description { get; set; }

    /// <summary>
    /// Workspace color.
    /// </summary>
    public string Color { get; set; } = WorkspaceDefaults.DefaultColor;

    /// <summary>
    /// Workspace icon.
    /// </summary>
    [StringLength(50)]
    public string Icon { get; set; } = WorkspaceDefaults.DefaultIcon;

    /// <summary>
    /// Indicates whether the workspace is marked as favorite.
    /// </summary>
    public bool IsFavorite { get; set; }
}