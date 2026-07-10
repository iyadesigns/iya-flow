using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IYA.Flow.Core.Entities;

public class Workspace : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Color { get; set; } = "#F7B7D3";

    public string Icon { get; set; } = "🦋";

    public bool IsFavorite { get; set; }
}