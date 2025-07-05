using System.Collections.Generic;

namespace Inkling.Models.Tools;

public sealed class MergePDFsToolOptions : ToolOptions
{
	public required List<int> Order { get; init; }
}
