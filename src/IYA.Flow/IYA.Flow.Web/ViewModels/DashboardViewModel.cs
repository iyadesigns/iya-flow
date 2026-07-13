namespace IYA.Flow.Web.ViewModels;

/// <summary>
/// ViewModel used by the Dashboard page.
/// </summary>
public class DashboardViewModel
{
    /// <summary>
    /// Total number of Workspaces.
    /// </summary>
    public int TotalWorkspaces { get; set; }

    /// <summary>
    /// Total number of Projects.
    /// </summary>
    public int TotalProjects { get; set; }

    /// <summary>
    /// Total number of Tasks.
    /// </summary>
    public int TotalTasks { get; set; }

    /// <summary>
    /// Total number of Notes.
    /// </summary>
    public int TotalNotes { get; set; }
}