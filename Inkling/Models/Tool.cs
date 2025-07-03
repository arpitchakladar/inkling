namespace Inkling.Models;

public abstract class Tool
{
	public string Name { get; }
	public string Description { get; }
	public bool MultiFile { get; }
	public string Color { get; }
	public string Icon { get; }

	protected Tool
		(
			string name,
			string description,
			bool multiFile,
			string color,
			string icon
		)
	{
		Name = name;
		Description = description;
		MultiFile = multiFile;
		Color = color;
		Icon = icon;
	}

	// public abstract Task RunAsync
	// (
	// 	IEnumerable<string> inputFiles,
	// 	string outputFolder,
	// 	ToolOptions? options = null
	// );
	//
	public static readonly Tool[] Tools = new Tool[]
	{
		new CompressPDFsTool(),
		new MergePDFsTool(),
		new SplitPDFTool(),
	};
}
