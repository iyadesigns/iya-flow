using IYA.Flow.Core.Constants;

namespace IYA.Flow.Core.Entities;

/// <summary>
/// Represents a workspace within the application.
/// </summary>
public class Workspace : BaseEntity
{
    /// <summary>
    /// Workspace name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Workspace description.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Main workspace color.
    /// </summary>
    public string Color { get; set; } = WorkspaceDefaults.DefaultColor;

    /// <summary>
    /// Lucide icon name.
    /// </summary>
    public string Icon { get; set; } = WorkspaceDefaults.DefaultIcon;

    /// <summary>
    /// Indicates whether the workspace is marked as favorite.
    /// </summary>
    public bool IsFavorite { get; set; }
}