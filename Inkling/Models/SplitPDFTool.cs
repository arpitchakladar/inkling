namespace Inkling.Models;

public sealed class SplitPDFTool: Tool
{
	public static SplitPDFTool Instance { get; } = new();

	public SplitPDFTool()
		: base(
			name: "Split PDF",
			description: "Split a PDF document into multiple smaller PDFs by page range or bookmarks. Perfect for extracting sections or separating large files.",
			color: "#25a47b",
			icon: "Scissors"
		)
	{}
}
