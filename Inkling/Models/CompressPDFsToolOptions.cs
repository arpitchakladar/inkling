namespace Inkling.Models;

public sealed class CompressPDFsToolOptions : ToolOptions
{
	public CompressionLevel CompressionLevel { get; init; } =
		CompressionLevel.Medium;
}
