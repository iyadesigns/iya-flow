using System.ComponentModel.DataAnnotations;

namespace IYA.Flow.Application.DTOs.Workspace;

/// <summary>
/// DTO used to update an existing Workspace.
/// </summary>
public class UpdateWorkspaceDto
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [StringLength(500)]
    public string? Description { get; set; }

    public string Color { get; set; } = string.Empty;

    public string? Icon { get; set; }

    public bool IsFavorite { get; set; }
}