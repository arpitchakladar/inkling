using System.Collections.Generic;

namespace Inkling.Models;

public sealed class SplitPDFToolOptions: ToolOptions
{
	public required List<int> Pages { get; init; }
}
