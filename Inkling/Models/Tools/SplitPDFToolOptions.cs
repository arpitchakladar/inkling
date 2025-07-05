using System.Collections.Generic;

namespace Inkling.Models.Tools;

public sealed class SplitPDFToolOptions : ToolOptions
{
	public required List<int> Pages { get; init; }
}
