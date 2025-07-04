namespace Inkling.Models;

public abstract class Tool
{
	public string Name { get; }
	public string Description { get; }
	public string Color { get; }
	public string Icon { get; }

	protected Tool(
		string name,
		string description,
		string color,
		string icon)
	{
		Name = name;
		Description = description;
		Color = color;
		Icon = icon;
	}

	// public abstract Task RunAsync
	// (
	// 	IEnumerable<string> inputFiles,
	// 	string outputPath, // Folder for multi file
	// 	ToolOptions? options = null
	// );

	public static readonly Tool[] Tools = new Tool[]
	{
		CompressPDFsTool.Instance,
		MergePDFsTool.Instance,
		SplitPDFTool.Instance,
	};
}
