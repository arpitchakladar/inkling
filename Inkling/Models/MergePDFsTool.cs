using System.Threading.Tasks;

namespace Inkling.Models;

public sealed class MergePDFsTool : Tool
{
	public static MergePDFsTool Instance { get; } = new();

	public MergePDFsTool()
		: base(
			name: "Merge PDFs",
			description: "Combine multiple PDF documents into a single, organized "
				+ "file. Ideal for merging reports, forms, or pages into one PDF.",
			color: "#db9b12",
			icon: "PaperClip"
		) { }

	public override async Task RunAsync(ToolOptions? options)
	{
		if (options is not MergePDFsToolOptions mergeOptions)
			return;
	}
}
