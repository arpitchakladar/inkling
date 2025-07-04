namespace Inkling.Models;

public sealed class CompressPDFsTool: Tool
{
	public static CompressPDFsTool Instance { get; } = new();

	private CompressPDFsTool()
		: base(
			name: "Compress PDFs",
			description: "Reduce the file size of one or more PDF documents while preserving as much quality as possible. Ideal for sharing or saving storage space.",
			color: "#db3612",
			icon: "/Assets/Icons/Tools/minimize-solid.svg"
		)
	{}
}
