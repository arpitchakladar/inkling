namespace Inkling.Models;

public sealed class SplitPDFTool: Tool
{
	public SplitPDFTool()
		: base(
			name: "Split PDF",
			description: "Split a PDF document into multiple smaller PDFs by page range or bookmarks. Perfect for extracting sections or separating large files.",
			color: "#25a47b",
			icon: "/Assets/Icons/Tools/scissors-solid.svg"
		)
	{}
}
