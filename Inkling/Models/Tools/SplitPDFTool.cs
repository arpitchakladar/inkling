using System.Threading.Tasks;

namespace Inkling.Models.Tools;

public sealed class SplitPDFTool : Tool
{
	public static SplitPDFTool Instance { get; } = new();

	public SplitPDFTool()
		: base(
			name: "Split PDF",
			description: "Split a PDF document into multiple smaller PDFs by page "
				+ "range or bookmarks. Perfect for extracting sections or separating "
				+ "large files.",
			color: "#25a47b",
			icon: "Scissors"
		) { }

	public override async Task RunAsync(ToolOptions? options)
	{
		if (options is not SplitPDFToolOptions splitOptions)
			return;
	}
}
