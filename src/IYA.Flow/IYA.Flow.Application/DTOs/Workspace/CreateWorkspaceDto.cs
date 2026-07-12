using System.ComponentModel.DataAnnotations;

namespace IYA.Flow.Application.DTOs.Workspace;

using IYA.Flow.Core.Constants;

/// <summary>
/// DTO used to create a new Workspace.
/// It contains only the information required by the user
/// when creating a Workspace.
/// </summary>
public class CreateWorkspaceDto
{
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
    /// Main color associated with the Workspace.
    /// </summary>
    public string Color { get; set; } = WorkspaceDefaults.DefaultColor;

    /// <summary>
    /// Workspace icon.
    /// </summary>
    [StringLength(50)]
    public string Icon { get; set; } = WorkspaceDefaults.DefaultIcon;
    /// <summary>
    /// Indicates whether the Workspace is marked as favorite.
    /// </summary>
    public bool IsFavorite { get; set; }
}