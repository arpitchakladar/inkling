using System.Collections.Generic;

namespace Inkling.Models;

public sealed class MergePDFsToolOptions: ToolOptions
{
	public required List<int> Order { get; init; }
}
