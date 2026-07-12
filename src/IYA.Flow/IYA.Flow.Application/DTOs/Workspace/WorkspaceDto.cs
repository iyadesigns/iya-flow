namespace IYA.Flow.Application.DTOs.Workspace;

/// <summary>
/// DTO used to display Workspace information.
/// </summary>
public class WorkspaceDto
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public string Color { get; set; } = string.Empty;

    public string? Icon { get; set; }

    public bool IsFavorite { get; set; }
}