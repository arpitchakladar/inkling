namespace Inkling.Models;

public sealed class CompressPDFsToolOptions: ToolOptions
{
	public required CompressionLevel CompressionLevel { get; init; }
}
